using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSmart.Data_Access_Layer;

namespace DataSmart.Business_Logic_Layer
{
    class Login
    {
        public static bool CheckLogin(string Username, string Password)
        {
            List<string> Users = new List<string>();
            Users = DH_TextFiles.ReadLogin();
            string check = Username + "#" + Password;
            if (Users != null)
            {
                foreach (var User in Users)
                {
                    if (User == check)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
