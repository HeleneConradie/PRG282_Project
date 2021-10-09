using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSmart.Data_Access_Layer
{
    class DH_WriteTextFiles
    {
        public static bool WriteTextFiles(string Login, string Detail)
        {
            try
            {
                string DetailPath = @"TextFiles/UserDetail.txt";
                string LoginPath = @"TextFiles/UserLogin.txt";
                FileStream fStream = new FileStream(LoginPath, FileMode.Append, FileAccess.Write);
                using (StreamWriter sr = new StreamWriter(fStream))
                {
                    sr.WriteLine(Login);

                }

                FileStream fStream1 = new FileStream(DetailPath, FileMode.Append, FileAccess.Write);
                using (StreamWriter sr = new StreamWriter(fStream1))
                {
                    sr.WriteLine(Detail);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
