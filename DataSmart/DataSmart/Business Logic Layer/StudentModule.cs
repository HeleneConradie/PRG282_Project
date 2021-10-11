using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class StudentModule
    {
        DH_StudentModule writeStuMod = new DH_StudentModule();
        List<StudentModule> StudentModules = new List<StudentModule>();

        string studentNumber;
        string modulecode;

        public StudentModule(string studentNumber, string modulecode)
        {
            this.StudentNumber = studentNumber;
            this.Modulecode = modulecode;
        }

        public string StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string Modulecode { get => modulecode; set => modulecode = value; }
    
        public List<StudentModule> DisplayAll(string stuNum)
        {
            StudentModules.AddRange(writeStuMod.ReadAll(stuNum));
            return StudentModules;
        }

        public string InsertStuMod(string stuNum)
        {
            bool Success = writeStuMod.InsertStudentModule(stuNum);
            if (Success == true)
            {
                return "StudentModules added successfully!";
            }
            return "OOPS! Something went wrong";
        }
    }
}
