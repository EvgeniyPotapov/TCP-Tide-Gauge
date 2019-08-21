using SimpleTCP;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace TCP_Client_TideMaster
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        DateTime dateTime = DateTime.UtcNow;
        internal static string logfilename = DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
        protected string Folderpath { get; set; } = @".\Data";
        public Form1()
        {
            InitializeComponent();
            tbRecive.Clear();
            Logger(DateTime.Now.ToString() + " Programm start" + Environment.NewLine);
            

        }
        private void CheckExistenceFolder()
        {
            if (!Directory.Exists(Folderpath))
            {
                Directory.CreateDirectory(Folderpath);
            }

        }
        private void WhatsNetwork()
        {switch (chbNetwork.Checked)
            {
                case true:
                    tbIPAdress.Text = "192.168.0.5";
                    break;
                case false:
                    tbIPAdress.Text = "109.188.128.115";
                    break;

            }

        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {

            CheckExistenceFolder();
            switch (btnConnect.Text)
            {
                case "Connect":
                    Connect();
                    databaseFileSorceToolStripMenuItem.Visible = false;
                    break;
                case "Disconnect":
                    Disconnect();
                    databaseFileSorceToolStripMenuItem.Visible = true;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
            Logger(DateTime.Now.ToString() + " Programm close" + Environment.NewLine);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient
            {
                StringEncoder = Encoding.ASCII
            };
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {

            Invoke((MethodInvoker)delegate
                 {
                     tbPackagetime.Text = DateTime.UtcNow.ToString();
                     string[] val = e.MessageString.Split(',');
                     string temp = val[2] + val[3];
                     dateTime = DateTime.ParseExact(temp, "ddMMyyyyHHmmss", CultureInfo.InvariantCulture);
                     tbMeasurmentTime.Text = dateTime.ToString();
                     tbTideHeight.Text = val[4];
                     tbRecive.AppendText(DateTime.Now.ToString() + " " + e.MessageString);
                     tmConnection.Stop();
                     tmConnection.Start();
                     if (pbConnect.Maximum != 60)
                     {
                         pbConnect.Maximum = 60;

                     }
                     pbConnect.Value = 0;
                     pbConnect.Refresh();
                     using (DBConnector dbConnector = new DBConnector())
                     {
                         DBConnector.DbFilePath = Folderpath;
                         dbConnector.Write(dateTime.ToString("s"), float.Parse(val[4]));
                     }
                 });
        }

        private void Tm1_Tick(object sender, EventArgs e)
        {
            switch (chbSilentMode.Checked)
            {
                case false:
                    Disconnect();
                    MessageBox.Show("Server not responding for a long time.\nConnection aborted", "Connection problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case true:
                    tbRecive.AppendText(DateTime.Now.ToString() + " Server not responding. Reconnecting" + Environment.NewLine);
                    Logger(DateTime.Now.ToString() + " Server not responding. Reconnecting" + Environment.NewLine);
                    Disconnect();
                    Connect();
                    break;
            }
           

        }

        

        private void TmProgress_Tick(object sender, EventArgs e)
        {
            
            try
            {
             pbConnect.Value++;
            }
            catch (Exception)
            {

               return;
            }
               
        }
        private void Disconnect()
        {
            btnConnect.Text = "Connect";
            chbNetwork.Visible = true;
            chbSilentMode.Visible = true;
            client.Disconnect();
            tmConnection.Dispose();
            tmProgress.Dispose();
            pbConnect.Visible = false;
            pbConnect.Value = 0;
            tbRecive.AppendText(DateTime.Now.ToString() + " Disconnected" + Environment.NewLine);
            Logger(DateTime.Now.ToString() + " Disconnected" + Environment.NewLine);
        }
        private void Connect()
        {
            try
            {
                client.Connect(tbIPAdress.Text, Convert.ToInt32(tbPort.Text));
                btnConnect.Text = "Disconnect";
                chbNetwork.Visible = false;
                chbSilentMode.Visible = false;
                tmConnection.Enabled = true;
                tmProgress.Enabled = true;
                pbConnect.Maximum = 120;
                pbConnect.Visible = true;
                tbRecive.AppendText(DateTime.Now.ToString() + " Connected" + Environment.NewLine);
                Logger(DateTime.Now.ToString() + " Connected" + Environment.NewLine);

            }
            catch (SocketException e)
            {
                if (e.ErrorCode==10065)
                {
                    tbRecive.AppendText(DateTime.Now.ToString() + " " + "Destination host is unreachable. Communication error" + " " + Environment.NewLine);
                }
                else
                {
                    tbRecive.AppendText(DateTime.Now.ToString() + " " + e + " " + Environment.NewLine);
                }
                
            }
            catch (Exception e)
            {
                tbRecive.AppendText(DateTime.Now.ToString() + " " + e.Message + " " + Environment.NewLine);
            }
           
        }
        private static void Logger(string Event)
        {
           string path = logfilename + ".log";
           using (StreamWriter filestrim = new StreamWriter(path, true))
            {
                filestrim.Write(Event);
                filestrim.Dispose();
            }
        }

        private void ChbNetwork_CheckedChanged(object sender, EventArgs e)
        {
            if (btnConnect.Text=="Disconnect")
            {
                Disconnect();
            }
            WhatsNetwork();
        }

        private void DatabaseFileSorceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolder = new FolderBrowserDialog())
            {
                openFolder.Description = "Select Directory...";
                openFolder.SelectedPath = Environment.CurrentDirectory;
                DialogResult result = openFolder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Folderpath = openFolder.SelectedPath;
                }
                openFolder.Dispose();
                
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            Logger(DateTime.Now.ToString() + " Programm close" + Environment.NewLine);
            ActiveForm.Dispose();
        }

        private void ExportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {


            using (Calendar calendar = new Calendar())
            {
                DateTime[] boldedDates;
                using (DBConnector dbConnector = new DBConnector())
                {
                    
                    DBConnector.DbFilePath = Folderpath;
                    dbConnector.GetDataRange();
                    DataTable _dataRange = dbConnector.DataRange;
                                        
                    boldedDates = new DateTime[_dataRange.Rows.Count];
                    
                    for (int i = 0; i < _dataRange.Rows.Count; i++)
                    {
                        DataRow dataRow = _dataRange.Rows[i];
                        string d= dataRow.Field<string>("DataTime");
                        boldedDates[i] = DateTime.ParseExact(d,"yyyy-MM-dd", CultureInfo.InvariantCulture);
                       

                    }
                   
                    
                    calendar.BDates(boldedDates);

                    if (calendar.ShowDialog() == DialogResult.OK)
                    {

                        using (DBConnector dBConnector = new DBConnector())
                        {
                            dBConnector.Read(calendar.DataChoosed);

                        }
                        tbRecive.AppendText("Export done");
                    }
                   
                }
                
            }
        }
    }
}
