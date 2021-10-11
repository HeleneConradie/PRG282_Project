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

namespace DataSmart.Data_Access_Layer
{
    class DH_ReadStudent
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public Image ConvertToImage(string stringImage)
        {
            byte[] Bytes = Convert.FromBase64String(stringImage);
            MemoryStream memoryStream = new MemoryStream(Bytes);
            Image StudImage = Image.FromStream(memoryStream, true, true);
            return StudImage;
        }

        #region Read Methods
        public List<Student> ReadAll()
        {
            try
            {
                List<Student> AllStudents = new List<Student>();
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM StudentInformation";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AllStudents.Add(new Student(
                        dr.GetValue(0).ToString(),
                        dr.GetValue(1).ToString(),
                        dr.GetValue(2).ToString(),
                        dr.GetValue(3).ToString(),
                        //dr.GetValue(4),
                        //Needs to be converted to Image type
                        dr.GetValue(5).ToString(),
                        dr.GetValue(6).ToString(),
                        dr.GetValue(7).ToString(),
                        dr.GetValue(5).ToString()
                        ));
                }
                connection.Close();
                return AllStudents;
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
                return null;
            }
        }

        public string ReadStudent(string StudentNumber)
        {
            string value = "";
            try
            {
                SqlConnection connection = new SqlConnection(dbHandler.connect);
                string Query = "SELECT * FROM StudentInformation WHERE StudentNumber ='" + StudentNumber + "'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    value = StudentNumber + "#" + dr.GetValue(1) + "#" + dr.GetValue(2) + "#" + dr.GetValue(3) + "#" + dr.GetValue(4) + "#" + dr.GetValue(5) + "#" + dr.GetValue(6) + "#" + dr.GetValue(7) + "#" + dr.GetValue(8);
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

        #endregion
    }
}
