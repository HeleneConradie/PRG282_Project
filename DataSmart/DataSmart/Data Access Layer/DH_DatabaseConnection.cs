using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_DatabaseConnection
    {
        private bool connected = false;

        private readonly string connection = @"Data Source = .; Intial Catalog = dbdDataSmart; Integrated Security = SSPI";

        public string connect { get => connection; }

        //Method to check if the server is connected.
        private void IsServerConnected (string ConnectionString) 
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                try
                {
                    sqlCon.Open();
                    connected = true;
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                    connected = false;
                    //throw new Exception(exc.Message);
                }
            }
        }
    }
}
