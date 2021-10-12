using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class RegisterUser
    {
        public static int Register(string UserName, string Password, string ConPass,string Name, string Surname, string email, int Camp)
        {
            int Val = Validation(Password, ConPass,Name, Surname, email);
            if (Val != -1)
            {
                return Val;
            }

            string Campus = "";
            switch (Camp)
            {
                case 0:
                    Campus = "PTA";
                    break;
                case 1:
                    Campus = "PE";
                    break;
                case 2:
                    Campus = "KP";
                    break;
            }

            string Login = UserName + "#" + Password;
            string Details = UserID + "#" + Name + "#" + Surname + "#" + email + "#" + Campus;
            bool Successful = DH_WriteTextFiles.WriteTextFiles(Login, Details);

            if (Successful == true)
            {
                return -1;
            }
            return -2;
        }

        public static int Validation(string Password, string ConPass ,string Name, string Surname, string email)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");


            if (!(hasNumber.IsMatch(Password) && hasUpperChar.IsMatch(Password) && hasMinimum8Chars.IsMatch(Password) && Password != null))
            {
                return 0;
            }

            if (ConPass.Equals(null)||(Password!=ConPass))
            {
                return 1;
            }

            if (hasNumber.IsMatch(Name) || Name.Equals(null))
            {
                return 2;
            }

            if (hasNumber.IsMatch(Surname) || Surname.Equals(null))
            {
                return 3;
            }

            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                return 4;
            }
            return -1;
        }
    }
}
