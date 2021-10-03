using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_ReadModule
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public ICollection<Module> ReadAll()
        {
            try
            {
                //Create list to display
                List<Module> AllModules = new List<Module>();
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Adding values to the list that are going to be displayed
                    AllModules.Add(new Module(
                        dr.GetValue(0).ToString(),
                        dr.GetValue(1).ToString(),
                        dr.GetValue(2).ToString(),
                        dr.GetValue(3).ToString()
                        ));
                }
                connection.Close();
                return AllModules.ToList();
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
                return null;
            }
        }

        public string ReadModule(string ModuleCode)
        {
            string value = "";
            try
            {
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation WHERE ModuleCode ='" + ModuleCode + "'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    value = dr.GetValue(0) + "#" + dr.GetValue(1) + "#" + dr.GetValue(2) + "#" + dr.GetValue(3);
                }
                connection.Close();
                return value;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                return null;
            }
        }
    }
}
