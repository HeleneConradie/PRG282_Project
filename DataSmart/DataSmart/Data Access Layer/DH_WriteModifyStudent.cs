using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSmart.Data_Access_Layer
{
    class DH_WriteModifyStudent
    {
        DH_DatabaseConnection dbHandler = new DH_DatabaseConnection();

        public bool InsertStudent(Student objStu)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = string.Format(@"INSERT INTO StudentInformation(StudentNumber, StudentFirtsName, StudentLastName, StudentImage, StudentDateOfBirth, StudentGender, StudentPhone, StudentAddress) Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}')",
                    objStu.StudentNumber,
                    objStu.StudentFirstName,
                    objStu.StudentLastName,
                    objStu.StudentImage,
                    objStu.StudentDateOfBirth,
                    objStu.StudentGender,
                    objStu.StudentPhone,
                    objStu.StudentAddress);
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

        public bool UpdateStudentImage(string StuNum, string StuImg)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "UPDATE StudentInformation SET StudentImage = '" + StuImg + "' WHERE StudentNumber = '" + StuNum + "'";
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

        public bool UpdateStudentPhone(string StuNum, string StuPhone)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "UPDATE StudentInformation SET StudentPhone = '" + StuPhone + "' WHERE StudentNumber = '" + StuNum + "'";
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

        public bool UpdateStudentAddress(string StuNum, string StuAddress)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbHandler.connect);
                string Query = "UPDATE StudentInformation SET StudentImage = '" + StuAddress + "' WHERE StudentNumber = '" + StuNum + "'";
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


