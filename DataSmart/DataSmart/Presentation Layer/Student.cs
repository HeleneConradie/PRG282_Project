using DataSmart.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSmart.Presentation_Layer
{
    public partial class frmStudent : Form
    {
        frmMenu MenuForm = new frmMenu();
        Student StudentClass = new Student();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnStudentBack_Click(object sender, EventArgs e)
        {
            MenuForm.Show();
            this.Hide();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {

            int Success = StudentClass.ValidationStudent(tbStudentNumber.Text,tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, pbStudentImage.Image,
                cbGender.Text, tbPhoneNumber.Text, tbAddress.Text);
            if (Success == 0)
            {
                MessageBox.Show("All fields need to be filled!", "Error!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Check the field lengths!", "Error!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Something went wrong. Please check that all fields are entered correctly!", "Error!");
            }
            if (Success == -1)
            {
                bool Successful = StudentClass.InsertStudentDetails(tbStudentNumber.Text, tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, pbStudentImage.Image,
                dtpDOB.Value.ToString("yyyy'-'MM'-'dd") ,cbGender.Text, tbPhoneNumber.Text, tbAddress.Text);
                if (Successful == false)
                {
                    MessageBox.Show("Something went wrong!", "OOPS!");
                }
                MessageBox.Show("Student has been added successfully!", "Success!");
                tbStudentNumber.Clear();
                tbFirstName.Clear();
                tbMiddleName.Clear();
                tbLastName.Clear();
                pbStudentImage.Image = null;
                cbGender.SelectedIndex = -1;
                tbPhoneNumber.Clear();
                tbAddress.Clear();
                tbStudentNumber.Focus();
            }
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            int Success = StudentClass.ValidationStudent(tbStudentNumber2.Text, tbStudentFirstName2.Text, tbMiddleName2.Text, tbLastName2.Text, pbStudentImage2.Image,
                cbGender2.Text, tbPhoneNumber2.Text, tbAddress2.Text);
            if (Success == 0)
            {
                MessageBox.Show("All fields need to be filled!", "Error!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Check the field lengths!", "Error!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Something went wrong. Please check that all fields are entered correctly!", "Error!");
            }
            if (Success == -1)
            {
                bool Successful = StudentClass.UpdateStudentInformation(tbStudentNumber2.Text, tbStudentFirstName2.Text, tbMiddleName2.Text, tbLastName2.Text, pbStudentImage2.Image,
                dtpDOB2.Value.ToString("yyyy'-'MM'-'dd"), cbGender2.Text, tbPhoneNumber2.Text, tbAddress2.Text);
                if (Successful == false)
                {
                    MessageBox.Show("Something went wrong!", "OOPS!");
                }
                MessageBox.Show("Student has been updated successfully!", "Success!");
                tbStudentNumber.Clear();
                tbFirstName.Clear();
                tbMiddleName.Clear();
                tbLastName.Clear();
                pbStudentImage2.Image = null;
                cbGender.SelectedIndex = -1;
                tbPhoneNumber.Clear();
                tbAddress.Clear();
                tbStudentNumber.Focus();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            int Success = StudentClass.DeleteValidation(tbStudentNumber2.Text);
            if (Success == 0)
            {
                MessageBox.Show("Student Number field needs to be filled!", "Error!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Check the Student Number field length!", "Error!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Something went wrong. Please check that the field is entered correctly!", "Error!");
            }
            if (Success == -1)
            {
                bool Successful = StudentClass.DeleteStudentDetails(tbStudentNumber2.Text);
                if (Successful == false)
                {
                    MessageBox.Show("Something went wrong!", "OOPS!");
                }
                MessageBox.Show("Student has been deleted successfully!", "Success!");
                tbStudentNumber.Clear();
                tbStudentNumber.Focus();
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            ofdStudentImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp;";
            if (ofdStudentImage.ShowDialog() == DialogResult.OK)
            {
                pbStudentImage.Image = new Bitmap(ofdStudentImage.FileName);
            }
        }

        private void btnChooseImage2_Click(object sender, EventArgs e)
        {
            ofdStudentImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp;";
            if (ofdStudentImage.ShowDialog() == DialogResult.OK)
            {
                pbStudentImage2.Image = new Bitmap(ofdStudentImage.FileName);
            }
        }

        private void frmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
