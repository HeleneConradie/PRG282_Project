using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Data_Access_Layer
{
    class DH_TextFiles
    {

        #region Write Methods
        public static bool WriteTextFiles(string Login, string Detail)
        {
            try
            {
                string DetailPath = @"UserDetails.txt";
                string LoginPath = @"UserLogin.txt";
                FileStream fStream = new FileStream(LoginPath, FileMode.Append, FileAccess.Write);
                using (StreamWriter sr = new StreamWriter(fStream))
                {
                    sr.WriteLine("\n"+Login);

                }

                FileStream fStream1 = new FileStream(DetailPath, FileMode.Append, FileAccess.Write);
                using (StreamWriter sr = new StreamWriter(fStream1))
                {
                    sr.WriteLine("\n"+Detail);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Read Login

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
        #endregion

        #region Read UserID
        public static List<string> ReadUserDetails()
        {
            try
            {
                List<string> Users = new List<string>();
                string path = @"UserDetails.txt";
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

        #endregion
    }
}
