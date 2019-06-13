using SimpleTCP;
using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TCP_Client_TideMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbRecive.Clear();
        }
        SimpleTcpClient client;
        DateTime dateTime = DateTime.UtcNow;
        
        
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //tbMeasurmentTime.Text = dateTime.ToString();
            switch (btnConnect.Text)
            {
                case "Connect":
                    Connect();
                    break;
                case "Disconnect":
                    Disconnect();
                    break;
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();

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
            //Update message to txtStatus
            tbRecive.Invoke((MethodInvoker)delegate ()
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
                    tbRecive.AppendText(DateTime.Now.ToString() + " Server not responding" + Environment.NewLine);
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
            client.Disconnect();
            tmConnection.Dispose();
            tmProgress.Dispose();
            pbConnect.Visible = false;
            pbConnect.Value = 0;
            tbRecive.AppendText(DateTime.Now.ToString() + " Disconnected" + Environment.NewLine);
        }
        private void Connect()
        {
            btnConnect.Text = "Disconnect";
            client.Connect(tbIPAdress.Text, Convert.ToInt32(tbPort.Text));
            tmConnection.Enabled = true;
            tmProgress.Enabled = true;
            pbConnect.Maximum = 120;
            pbConnect.Visible = true;
            tbRecive.AppendText(DateTime.Now.ToString() + " Connected" + Environment.NewLine);

        }
    }
}
