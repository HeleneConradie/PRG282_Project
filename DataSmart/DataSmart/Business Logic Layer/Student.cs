using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class Student
    {
        DH_Student student = new DH_Student();
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

        public bool InsertStudentDetails(string num, string name, string middleName, string surname, Image img, string dob, string gender, string phone, string address)
        {
            bool Success = student.InsertStudent(num, name, middleName, surname, img, dob, gender, phone, address);
            if (Success == true)
            {
                return true;
            }
            return false;
        }

        public bool DeleteStudentDetails(string stuNum)
        { 
            bool Success = student.DeleteStudent(stuNum);
            if (Success == true)
            {
                return true;
            }
            return false;
        }

        public List<Student> DisplayAllStudents()
        {
            Students.AddRange(student.ReadAll());
            return Students;
        }

        //public Image ConvertToImage(string stringImage)
        //{
        //    byte[] Bytes = Convert.FromBase64String(stringImage);
        //    MemoryStream memoryStream = new MemoryStream(Bytes);
        //    Image StudImage = Image.FromStream(memoryStream, true, true);
        //    return StudImage;
        //}

        public string DisplaySearchedStudent(string StudentID)
        {
            string FoundStudent = student.ReadStudent(StudentID);
            if (FoundStudent != null)
            {
                object[] StudentContent = FoundStudent.Split('#');
                //Image[] Image = new Image[1];
                //Image[0] = ConvertToImage(StudentContent[4].ToString());

                Students.Add(new Student(StudentContent[0].ToString(), StudentContent[1].ToString(), StudentContent[2].ToString(), StudentContent[3].ToString(), /*Image[0]*/ StudentContent[5].ToString(), StudentContent[6].ToString(), StudentContent[7].ToString(), StudentContent[8].ToString()));
                //return Students;
            }
            return null;
        }

        public bool UpdateStudentInformation(string StudNum, string StuName, string StuMiddleName, string StuSurname, Image StuImage, string DOB, string Gender, string Phone, string Address)
        {
            bool Success = student.UpdateStudent(StudNum, StuName, StuMiddleName, StuSurname, StuImage, DOB, Gender, Phone, Address);
            if (Success == true)
            {
                return true;
            }
            return false;
        }

        public int ValidationStudent(string StuNumber, string StuFName, string StuMName, string StuLName, string StuImage, string StuGender, string StuPhone, string StuAddress)
        {
            Regex numvalidation = new Regex("^[a-zA-Z0-9]*$");
            Regex stringvalidation = new Regex("^[A-Z][a-zA-Z]*$");
            Regex addressvalidation = new Regex("^[0-9a-zA-Z]*$");
            Regex phonenumber = new Regex("^[+27|0][6-8][0-9]{7}$");

            bool isValidNumber = numvalidation.IsMatch(StuNumber);
            bool isValidName = stringvalidation.IsMatch(StuFName);
            bool isValidMName = stringvalidation.IsMatch(StuMName);
            bool isValidLName = stringvalidation.IsMatch(StuLName);
            bool isValidPhone = phonenumber.IsMatch(StuPhone);
            bool isValidAddress = addressvalidation.IsMatch(StuAddress);

            if (StuNumber.Equals(null) || StuFName.Equals(null) || StuLName.Equals(null) || StuImage.Equals(null) || StuGender.Equals(null) || StuPhone.Equals(null)||
                StuAddress.Equals(null))
            {
                return 0;
            }
            if (StuNumber.Length > 7 || StuNumber.Length < 5 || StuFName.Length > 50 || StuMName.Length > 50 || StuLName.Length > 50 || StuAddress.Length > 50)
            {
                return 2;
            }
            if (isValidNumber && isValidName && isValidMName && isValidLName && isValidPhone && isValidAddress)
            {
                return -1;
            }
            return 2;
        }

        public int DeleteValidation(string StuNumber)
        {
            Regex numvalidation = new Regex("^[a-zA-Z0-9]*$");
            bool isValidNumber = numvalidation.IsMatch(StuNumber);

            if (StuNumber.Equals(null))
            {
                return 0;
            }
            if (StuNumber.Length > 7 || StuNumber.Length < 5)
            {
                return 1;
            }
            if (isValidNumber)
            {
                return -1;
            }
            return 2;
        }
    }
}
