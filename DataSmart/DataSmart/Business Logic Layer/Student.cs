using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class Student
    {
        DH_WriteModifyStudent writestu = new DH_WriteModifyStudent();
        DH_Student readstu = new DH_Student();
        List<Student> Students = new List<Student>();

        string studentnumber;
        string studentName;
        string studentMiddleName;
        string studentSurname;
        Image studentImage;
        string studentDatOfBirth;
        string studentGender;
        string studentPhone;
        string studentAddress;

        public string Studentnumber { get => studentnumber; set => studentnumber = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentMiddleName { get => studentMiddleName; set => studentMiddleName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public Image StudentImage { get => studentImage; set => studentImage = value; }
        public string StudentDatOfBirth { get => studentDatOfBirth; set => studentDatOfBirth = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string StudentPhone { get => studentPhone; set => studentPhone = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }

        public Student() { }

        public Student(string studentnumber, string studentName, string studentMiddleName, string studentSurname, Image studentImage, string studentDatOfBirth, string studentGender, string studentPhone, string studentAddress)
        {
            this.Studentnumber = studentnumber;
            this.StudentName = studentName;
            this.StudentMiddleName = studentMiddleName;
            this.StudentSurname = studentSurname;
            this.StudentImage = studentImage;
            this.StudentDatOfBirth = studentDatOfBirth;
            this.StudentGender = studentGender;
            this.StudentPhone = studentPhone;
            this.StudentAddress = studentAddress;
        }

        public string InsertStudentDetails(string num, string name, string middleName, string surname, Image img, string dob, string gender, string phone, string address)
        {
            bool Success = writestu.InsertStudent(num, name, middleName, surname, img, dob, gender, phone, address);
            if (Success == true)
            {
                return "Student added successfully!";
            }
            return "OOPS! Something went wrong";
        }

        public string DeleteStudentDetails(string stuNum)
        { 
            bool Success = writestu.DeleteStudent(stuNum);
            if (Success == true)
            {
                return "Student has been deleted successfully!";
            }
            return "OOPS! Something went wrong";
        }

        public List<Student> DisplayAllStudents()
        {
            Students.AddRange(readstu.ReadAll());
            return Students;
        }

        public Image ConvertToImage(string stringImage)
        {
            byte[] Bytes = Convert.FromBase64String(stringImage);
            MemoryStream memoryStream = new MemoryStream(Bytes);
            Image StudImage = Image.FromStream(memoryStream, true, true);
            return StudImage;
        }

        public string DisplaySearchedStudent(string StudentID)
        {
            string FoundStudent = readstu.ReadStudent(StudentID);
            if (FoundStudent != null)
            {
                object[] StudentContent = FoundStudent.Split('#');
                Image[] Image = new Image[1];
                Image[0] = ConvertToImage(StudentContent[4].ToString());

                Students.Add(new Student(StudentContent[0].ToString(), StudentContent[1].ToString(), StudentContent[2].ToString(), StudentContent[3].ToString(), Image[0], StudentContent[5].ToString(), StudentContent[6].ToString(), StudentContent[7].ToString(), StudentContent[8].ToString()));
                //return Students;
            }
            return null;
        }

        public string UpdateStudentInformation(string StudNum, string StuName, string StuMiddleName, string StuSurname, Image StuImage, string DOB, string Gender, string Phone, string Address)
        {
            bool Success = writestu.UpdateStudent(StudNum, StuName, StuMiddleName, StuSurname, StuImage, DOB, Gender, Phone, Address);
            if (Success == true)
            {
                return "Student has been updated successfully!";
            }
            return "OOPS! Something went wrong";
        }
    }
}
