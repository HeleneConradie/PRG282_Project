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
    public partial class frmLogin : Form
    {
        frmRegister reg = new frmRegister();
        frmMenu menu = new frmMenu();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = tbUsername.Text;
            string Password = tbPassword.Text;
            if (Login.CheckLogin(Username, Password))
            {
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            reg.Show();
            this.Hide();
        }

<<<<<<< Updated upstream
        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•';
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '•';
=======
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
>>>>>>> Stashed changes
        }
    }
}
