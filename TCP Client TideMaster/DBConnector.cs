using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
using System;

namespace TCP_Client_TideMaster
{
   
    class DBConnector:IDisposable
    {
        public static string DbFilePath { get; set; } = "";
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

        void IDisposable.Dispose()
        {
            dbCommand.Dispose();
            dbConnection.Dispose();
        }

        
    }

}
