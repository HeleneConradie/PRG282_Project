using DataSmart.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_Module
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();
        List<Module> AllModules = new List<Module>();

        #region Read Methods
        public List<Module> ReadAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AllModules.Add(new Module(
                        dr.GetValue(0).ToString(),
                        dr.GetValue(1).ToString(),
                        dr.GetValue(2).ToString(),
                        dr.GetValue(3).ToString()
                        ));
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

        public DataTable ReadModule(string ModuleCode)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM ModuleInformation WHERE ModuleCode ='" + ModuleCode + "'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataAdapter sqlDAdpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDAdpt.Fill(dt);
                return dt;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                return null;
            }
        }

        #endregion

        #region Insert Method
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
        #endregion

        #region Update Method

        public bool UpdateModuleInformation(string ModCode, string ModDesc, string OnResources)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "UPDATE ModuleInformation SET ModuleDescription = '" + ModDesc + "', OnlineResources = '" + OnResources + "' WHERE ModuleCode = '" + ModCode + "'";
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
        #endregion

        #region Delete Method
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
        #endregion
    }
}
