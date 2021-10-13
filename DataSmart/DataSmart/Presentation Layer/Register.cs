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
                    MessageBox.Show("Email is invalid!");
                    break;
            }
            tbName.Clear();
            tbSurname.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            tbConPass.Clear();
            cbCampus.SelectedIndex = -1;

        }

        private void btnRegBack_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tbConPass.PasswordChar = '\0';
        }

        private void pbConShow_MouseUp(object sender, MouseEventArgs e)
        {
            tbConPass.PasswordChar = '•';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•';
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '•';
        }

        private void tbConPass_TextChanged(object sender, EventArgs e)
        {
            tbConPass.PasswordChar = '•';
        }
    }
}
