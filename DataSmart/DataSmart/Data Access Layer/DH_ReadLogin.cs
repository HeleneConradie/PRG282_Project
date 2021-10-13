using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_ReadLogin
    {
        public static List<string> ReadLogin()
        {
            try
            {
                List<string> Users = new List<string>();
                string path = @"UserLogin.txt";
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                using (StreamReader sReader = new StreamReader(fStream))
                {
                    string line;
                    while ((line = sReader.ReadLine()) != null)
                    {
                        Users.Add(line);
                    }
                }
                return Users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
