using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_ReadWriteStudentModule
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public List<string> ReadAll(string StuNum)
        {
            try
            {
                //Create list to display
                List<string> AllModules = new List<string>();
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AllModules.Add(StuNum + dr.GetValue(0).ToString());
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

        public bool InsertStudentModule(string StuNum, StudentModule objStuMod)
        {
            try
            {
                //Create list to display
                List<string> AllModules = new List<string>();
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AllModules.Add(StuNum + "," + dr.GetValue(0).ToString());
                }
                connection.Close();
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }

            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = string.Format(@"INSERT INTO StudentModule
                    (StudentNumber, ModuleCode) VALUES ('{0}', '{1}')",
                    objStuMod.StudentNumber,
                    objStuMod.ModuleCode);
                SqlCommand command = new SqlCommand(Query, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
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
