using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSmart.Business_Logic_Layer;

namespace DataSmart.Presentation_Layer
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string Surname = tbSurname.Text;
            string email = tbEmail.Text;
            string Username = Name + Surname;
            string Password = tbPassword.Text;
            string ConPass = tbConPass.Text;
            int Campus = cbCampus.SelectedIndex;

            switch (RegisterUser.Register(Username, Password, ConPass, Name, Surname, email, Campus))
            {
                case -2:
                    MessageBox.Show("OOPS! Something went wrong.");
                    break;
                case -1:
                    MessageBox.Show("Successfuly Registered!");
                    break;
                case 0:
                    MessageBox.Show("Password is invalid!");
                    break;
                case 1:
                    MessageBox.Show("Passwords must match!");
                    break;
                case 2:
                    MessageBox.Show("Name is invalid!");
                    break;
                case 3:
                    MessageBox.Show("Surname is invalid!");
                    break;
                case 4:
                    MessageBox.Show("Emial is invalid!");
                    break;
            }
        }
    }
}
