using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
using System;
using System.Data;
using System.Linq;
using System.Globalization;

namespace TCP_Client_TideMaster
{
   
    class DBConnector:IDisposable
    {
        private static string _dbFilepath = @".\Data\TideGaugeCofferdam.db";
        public static string DbFilePath { get => _dbFilepath; set => _dbFilepath = value + @"\TideGaugeCofferdam.db"; }
        private SQLiteConnection dbConnection;
        private readonly SQLiteCommand dbCommand = new SQLiteCommand();
       
        public void CreateFile()
        {
            SQLiteConnection.CreateFile(DbFilePath);
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + DbFilePath + ";Version=3;");
                dbConnection.Open();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS Tide (id INTEGER PRIMARY KEY AUTOINCREMENT, DataTime TEXT, Level REAL)";
                dbCommand.ExecuteNonQuery();


            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void Connect()
        {
            if (!File.Exists(DbFilePath))
            {
               CreateFile();
            }
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + DbFilePath + ";Version=3;");
                dbConnection.Open();
                dbCommand.Connection = dbConnection;
                         

            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

        }
        public void Write(string DataTime, float Level)
        {
            Connect();
            try
            {
                dbCommand.CommandText = "INSERT INTO Tide ('DataTime', 'Level') values ('" +
                    DataTime + "' , '" +
                    Level+ "')";

                dbCommand.ExecuteNonQuery();
                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Read ()
        {
            Connect();
            try
            {
                using (DataTable dataTable = new DataTable())
                {
                    string CommandText = "SELECT DATATIME, Level FROM Tide";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(CommandText, dbConnection);
                    dataAdapter.Fill(dataTable);
                    string exportFilePath = @".\Data\" + DateTime.Now.ToString("yyyyMMdd-HHmmss", CultureInfo.InvariantCulture) + "_Tide.csv";
                    StreamWriter FileExportCSV = new StreamWriter(exportFilePath);
                    using (FileExportCSV)
                    {
                        FileExportCSV.WriteLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(csvfile => csvfile.ColumnName)));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            FileExportCSV.WriteLine(string.Join(",", row.ItemArray));
                        }
                    }
                    dbConnection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Export done");
        }
        void IDisposable.Dispose()
        {
            dbCommand.Dispose();
            dbConnection.Dispose();
        }

        
    }

}
