using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataSmart.Business_Logic_Layer;
using System.Drawing;
using System.IO;
using System.Data;
using System.Drawing.Imaging;

namespace DataSmart.Data_Access_Layer
{
    class DH_Student
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        #region Read Methods
        public DataTable ReadAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM StudentInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataAdapter sqlDAdpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDAdpt.Fill(dt);
                return dt;
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
                return null;
            }
        }

        public DataTable ReadStudent(string StudentNumber)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM StudentInformation WHERE StudentNumber ='" + StudentNumber + "'";
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

        public bool InsertStudent(string StuNum, string StuName, string middleName, string StuSurname, Image StuImage, string StuDOB, string StuGender, string Phone, string StuAddress)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                con.Open();
                string Query = string.Format(@"INSERT INTO StudentInformation(StudentNumber, StudentFirstName, StudentMiddleName, StudentLastName, StudentImage, StudentDateOfBirth, StudentGender, StudentPhone, StudentAddress) 
                    Values ('" + StuNum + "', '" + StuName + "', '" + middleName + "', '" + StuSurname + "', @P_Image, '" + StuDOB + "', '" + StuGender + "', '" + Phone + "', '" + StuAddress + "')");
                using (SqlCommand command = new SqlCommand(Query, con))
                {
                    MemoryStream ms = new MemoryStream();
                    StuImage.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    command.Parameters.AddWithValue("@P_Image", photo_aray);
                    command.ExecuteNonQuery();
                }
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
        public bool UpdateStudent(string StuNum, string StuName, string StuMiddleName, string StuSurname, Image StuImage, string StuDOB, string StuGender, string Phone, string StuAddress)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                con.Open();
                string Query = "UPDATE StudentInformation SET StudentFirstName = '" + StuName + "', StudentMiddleName = '" + StuMiddleName + "', StudentLastName = '" + StuSurname + "', StudentImage = @P_Image, StudentDateOfBirth = '" + StuDOB + "'" +
                    ", StudentGender = '" + StuGender + "', StudentPhone = '" + Phone + "', StudentAddress = '" + StuAddress + "' WHERE StudentNumber = '" + StuNum + "'";
                using (SqlCommand command = new SqlCommand(Query, con))
                {
                    MemoryStream ms = new MemoryStream();
                    StuImage.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    command.Parameters.AddWithValue("@P_Image", photo_aray);
                    command.ExecuteNonQuery();
                }
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

        #region Delete Method
        public bool DeleteStudent(string StuNum)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "DELETE FROM StudentInformation WHERE StudentNumber = '" + StuNum + "'";
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

        #region Student Read Image Method

        public MemoryStream ReadImageFromDatabase(string StuNum)
        {
            System.Drawing.Image image = null;
            int i = 0;
            using (SqlConnection sqlConnection = new SqlConnection(dbHandler.connect))
            {
                sqlConnection.Open();
                string queryImage = "SELECT StudentImage FROM StudentInformation WHERE StudentNumber = '" + StuNum + "'";
                SqlCommand sqlcmd = new SqlCommand(queryImage, sqlConnection);
                SqlDataAdapter dataAdpt = new SqlDataAdapter(sqlcmd);
                DataSet dataSet = new DataSet();
                dataAdpt.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])dataSet.Tables[0].Rows[0]["StudentImage"]);
                    return ms;
                }
                else return null;
            }
        }
        #endregion
    }
}
