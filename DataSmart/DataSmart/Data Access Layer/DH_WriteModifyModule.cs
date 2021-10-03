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

        public bool InsertModule(Module objMod)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = string.Format(@"INSERT INTO ModuleInformation
                    (ModuleCode, ModuleName, ModuleDescription, OnlineResources) VALUES ('{0}', '{1}', '{2}', '{3}')", 
                    objMod.ModuleCode,
                    objMod.ModuleName,
                    objMod.ModuleDescription,
                    objMod.OnlineResources);
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

        //public bool UpdateModule(Module NewobjMod, Module OldobjMod)
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(dbHandler.connect);
        //        string Query = string.Format(@"UPDATE ModuleInformation SET (ModuleCode = '{1}', ModuleName = '{2}', 
        //             ModuleDescription = '{3}', OnlineResources = '{4}') WHERE", 
        //            OldobjMod.ModuleCode,
        //            NewobjMod.ModuleCode,
        //            NewobjMod.ModuleName,
        //            NewobjMod.ModuleDescription,
        //            NewobjMod.OnlineResources);
        //        SqlCommand command = new SqlCommand(Query, con);
        //        con.Open();
        //        command.ExecuteNonQuery();
        //        con.Close();
        //        return true;
        //    }
        //    catch (SqlException sqlEx)
        //    {
        //        MessageBox.Show(sqlEx.Message);
        //        return false;
        //    }
        //}

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
