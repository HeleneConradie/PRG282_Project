using DataSmart.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_WriteModifyModule
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public bool InsertModule(string modcode, string modname, string moddesc, string onres)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = string.Format(@"INSERT INTO ModuleInformation
                    (ModuleCode, ModuleName, ModuleDescription, OnlineResources) VALUES 
                        ('" + modcode + "', '" + modname + "', '" + moddesc + "', '" + onres + "')");
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

        public bool UpdateModuleInformation(string ModCode, string ModDesc, string OnResources)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "UPDATE ModuleInformation SET (OnlineResources = '" + OnResources + "') WHERE ModuleCode = '" + ModCode + "'";
                SqlCommand command = new SqlCommand(Query, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteModule(string ModuleCode)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "DELETE FROM ModuleInformation WHERE ModuleCode = '" + ModuleCode + "'";
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
