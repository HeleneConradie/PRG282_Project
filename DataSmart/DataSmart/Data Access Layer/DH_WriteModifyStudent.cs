using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace DataSmart.Data_Access_Layer
{
    class DH_WriteModifyStudent
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public bool InsertStudent(string StuNum, string StuName, string StuSurname, Image StuImage, string StuDOB, string StuGender, string Phone, string StuAddress)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = string.Format(@"INSERT INTO StudentInformation(StudentNumber, StudentFirtsName, StudentLastName, StudentImage, StudentDateOfBirth, StudentGender, StudentPhone, StudentAddress) 
                    Values ('" + StuNum + "', '" + StuName + "', '" + StuSurname + "', '" + StuImage + "', '" + StuDOB + "', '" + StuGender + "', '" + Phone + "', '" + StuAddress + "')");
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

        public bool UpdateStudent(string StuNum, string StuName, string StuMName, string StuSurname, Image StuImage, string StuDOB, string StuGender, string Phone, string StuAddress)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "UPDATE StudentInformation SET (StudentFirstName = '" + StuName + "', StudentMiddleName = '" + StuMName + "', StudentLastName = '" + StuSurname + "', StudentImage = '" + StuImage + "', StudentDateOfBirth = '" + StuDOB + "'" +
                    ", StudentGender = '" + StuGender + "', StudentPhone = '" + Phone + "', StudentAddress = '" + StuAddress + "') WHERE StudentNumber = '" + StuNum+ "'";
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
    }
}


