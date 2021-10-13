using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Presentation_Layer
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmModule moduleForm = new frmModule();
            frmDisplay displayForm = new frmDisplay();
            frmStudent studentForm = new frmStudent();

            if (rbtnModule.Checked == true)
            {
                if (rbtnModify.Checked == true)
                {
                    this.Hide();
                    moduleForm.Show();
                    moduleForm.pnlModifyModule.Show();
                    moduleForm.pnlAddModule.Hide();
                }
                else if (rbtnAdd.Checked == true)
                {
                    this.Hide();
                    moduleForm.Show();
                    moduleForm.pnlAddModule.Show();
                    moduleForm.pnlModifyModule.Hide();
                }
                else if (rbtnSearch.Checked == true)
                {
                    this.Hide();
                    displayForm.Show();
                }
                else if (rbtnViewAll.Checked == true)
                {
                    this.Hide();
                    displayForm.Show();
                    displayForm.displayModule();
                }
                else MessageBox.Show("Please choose an option");               
            }
            if (rbtnStudent.Checked == true)
            {
                if (rbtnModify.Checked == true)
                {
                    this.Hide();
                    studentForm.Show();
                    studentForm.pnlModifyStudent.Show();
                    studentForm.pnlAddStudent.Hide();
                }
                else if (rbtnAdd.Checked == true)
                {
                    this.Hide();
                    studentForm.Show();
                    studentForm.pnlAddStudent.Show();
                    studentForm.pnlModifyStudent.Hide();
                }
                else if (rbtnSearch.Checked == true)
                {
                    this.Hide();
                    displayForm.Show();
                }
                else if (rbtnViewAll.Checked == true)
                {
                    this.Hide();
                    displayForm.Show();
                    displayForm.displayStudent();
                }
                else MessageBox.Show("Please choose an option");
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
