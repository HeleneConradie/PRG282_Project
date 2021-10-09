using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class RegisterUser
    {
        public bool Register(string UserName, string Password, string UserID, string Name, string Surname, string email, string Campus)
        {
            string Login = UserName + "#" + Password;
            string Details = UserID + "#" + Name + "#" + Surname + "#" + email + "#" + Campus;
            return DH_WriteTextFiles.WriteTextFiles(Login, Details);
        }
    }
}
