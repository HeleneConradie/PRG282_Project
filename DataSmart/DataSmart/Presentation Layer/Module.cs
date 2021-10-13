using DataSmart.Business_Logic_Layer;
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
    public partial class frmModule : Form
    {
        frmMenu MainMenu = new frmMenu();
        Module ModuleClass = new Module();

        public frmModule()
        {
            InitializeComponent();
        }

        private void btnModBack_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Close();
        }

        private void btnModAdd_Click(object sender, EventArgs e)
        {
            int Success = ModuleClass.ValidationModule(tbModCode.Text, tbModName.Text, tbModDesc.Text, tbOnlineRes.Text);
            if (Success == 0)
            {
                MessageBox.Show("Error!", "All fields need to be filled!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Error!", "Check the field lengths!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Error!", "Something went wrong. Please check that all fields are entered correctly!");
            }
            if (Success == -1)
            {
                bool Successful = ModuleClass.InsertMod(tbModCode.Text, tbModName.Text, tbModDesc.Text, tbOnlineRes.Text);
                if (Successful == false)
                {
                    MessageBox.Show("OOPS!", "Something went wrong!");
                }
                MessageBox.Show("Success!", "Module has been added successfully!");
                tbModCode.Clear();
                tbModName.Clear();
                tbModDesc.Clear();
                tbOnlineRes.Clear();
                tbModCode.Focus();
            }
        }

        private void btnModUpdate_Click(object sender, EventArgs e)
        {
            int Success = ModuleClass.ValidationModule(tbModCode2.Text, tbModName2.Text, tbModDesc2.Text, tbOnlineRes2.Text);
            if (Success == 0)
            {
                MessageBox.Show("Error!", "All fields need to be filled!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Error!", "Check the field lengths!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Error!", "Something went wrong. Please check that all fields are entered correctly!");
            }
            if (Success == -1)
            {
                bool Successful = ModuleClass.UpdateModule(tbModCode2.Text, tbModDesc2.Text, tbOnlineRes2.Text);
                if (Successful == false)
                {
                    MessageBox.Show("OOPS!", "Something went wrong!");
                }
                MessageBox.Show("Success!", "Module has been updated successfully!");
                tbModCode2.Clear();
                tbModName2.Clear();
                tbModDesc2.Clear();
                tbOnlineRes2.Clear();
                tbModCode2.Focus();
            }
        }

        private void btnModDelete_Click(object sender, EventArgs e)
        {
            int Success = ModuleClass.DeleteValidation(tbModCode2.Text);
            if (Success == 0)
            {
                MessageBox.Show("Error!", "Module Code field cannot be empty!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Error!", "Check the Module Code field length!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Error!", "Something went wrong. Please check that the field is entered correctly!");
            }
            if (Success == -1)
            {
                bool Successful = ModuleClass.ModDelete(tbModCode2.Text);
                if (Successful == false)
                {
                    MessageBox.Show("OOPS!", "Something went wrong!");
                }
                MessageBox.Show("Success!", "Module has been deleted successfully!");
                tbModCode2.Clear();
                tbModCode2.Focus();
            }
        }

    }
}
