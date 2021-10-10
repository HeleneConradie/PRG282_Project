using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSmart.Business_Logic_Layer;

namespace DataSmart.Data_Access_Layer
{
    class DH_ReadWriteStudentModule
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public List<StudentModule> ReadAll(string stuNum)
        {
            try
            {
                //Create list to display
                List<StudentModule> AllModules = new List<StudentModule>();
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AllModules.Add(new StudentModule(stuNum, dr.GetValue(0).ToString()));
                }
                connection.Close();
                return AllModules;
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
                return null;
            }
        }

        public bool InsertStudentModule(string StuNum)
        {
            try
            {
                //Create list to display
                List<string> AllModules = new List<string>();
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query1 = "SELECT * FROM ModuleInformation";
                SqlCommand cmd = new SqlCommand(Query1, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AllModules.Add(StuNum + "," + dr.GetValue(0).ToString());
                }
                SqlConnection con = new SqlConnection(dbHandler.connect);
                foreach(var item in AllModules)
                {
                    string Query2 = string.Format(@"INSERT INTO StudentModule
                    (StudentNumber, ModuleCode) VALUES ('{0}', '{1}')",
                    item.Substring(0,item.IndexOf(',')),
                    item.Substring(item.IndexOf(','),item.Length));
                    SqlCommand command = new SqlCommand(Query2, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                return false;
            }
        }
    }
}
