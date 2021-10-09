using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class Student
    {
        DH_WriteModifyStudent writestu = new DH_WriteModifyStudent();
        DH_ReadStudent readstu = new DH_ReadStudent();
        List<Student> Students = new List<Student>();

        string studentnumber;
        string studentName;
        string studentSurname;
        Image studentImage;
        string studentDatOfBirth;
        string studentGender;
        string studentPhone;
        string studentAddress;

        public Student(string studentnumber, string studentName, string studentSurname, Image studentImage, string studentDatOfBirth, string studentGender, string studentPhone, string studentAddress)
        {
            this.Studentnumber = studentnumber;
            this.StudentName = studentName;
            this.StudentSurname = studentSurname;
            this.StudentImage = studentImage;
            this.StudentDatOfBirth = studentDatOfBirth;
            this.StudentGender = studentGender;
            this.StudentPhone = studentPhone;
            this.StudentAddress = studentAddress;
        }

        public string Studentnumber { get => studentnumber; set => studentnumber = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public Image StudentImage { get => studentImage; set => studentImage = value; }
        public string StudentDatOfBirth { get => studentDatOfBirth; set => studentDatOfBirth = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string StudentPhone { get => studentPhone; set => studentPhone = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
    
        public Student() { }

        public string InsertStu(string num, string name, string surname, Image img, string dob, string gender, string phone, string address)
        {
            bool Success = writestu.InsertStudent(num, name, surname, img, dob, gender, phone, address);
            if (Success == true)
            {
                return "Student added successfully!";
            }
            return "Oops! Something went wrong";
        }

        public string ModDelete(string stuNum)
        { 
            bool Success = writestu.DeleteStudent(stuNum);
            if (Success == true)
            {
                return "Student has been deleted successfully!";
            }
            return "Oops! Something went wrong";
        }

        public List<Student> DisplayAll()
        {
        }
    }
}
