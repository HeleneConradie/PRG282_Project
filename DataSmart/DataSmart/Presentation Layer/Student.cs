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
            int Success = StudentClass.ValidationStudent(tbStudentNumber.Text,tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, tbImagePath,
                cbGender.Text, tbPhoneNumber.Text, tbAddress.Text);
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
                //bool Successful = StudentClass.InsertStudentDetails(tbStudentNumber.Text, tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, tbImagePath,
                //cbGender.Text, tbPhoneNumber.Text, tbAddress.Text);
                if (Successful == false)
                {
                    MessageBox.Show("OOPS!", "Something went wrong!");
                }
                MessageBox.Show("Success!", "Student has been added successfully!");
                tbStudentNumber.Clear();
                tbFirstName.Clear();
                tbMiddleName.Clear();
                tbLastName.Clear();
                tbImagePath.Clear();
                cbGender.SelectedIndex = -1;
                tbPhoneNumber.Clear();
                tbAddress.Clear();
                tbStudentNumber.Focus();
            }
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            int Success = StudentClass.ValidationStudent(tbStudentNumber.Text, tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, tbImagePath,
                cbGender.Text, tbPhoneNumber.Text, tbAddress.Text);
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
                //bool Successful = StudentClass.UpdateStudentInformation(tbStudentNumber.Text, tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, tbImagePath,
                //cbGender.Text, tbPhoneNumber.Text, tbAddress.Text);
                if (Successful == false)
                {
                    MessageBox.Show("OOPS!", "Something went wrong!");
                }
                MessageBox.Show("Success!", "Student has been updated successfully!");
                tbStudentNumber.Clear();
                tbFirstName.Clear();
                tbMiddleName.Clear();
                tbLastName.Clear();
                tbImagePath.Clear();
                cbGender.SelectedIndex = -1;
                tbPhoneNumber.Clear();
                tbAddress.Clear();
                tbStudentNumber.Focus();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            int Success = StudentClass.DeleteValidation(tbStudentNumber.Text);
            if (Success == 0)
            {
                MessageBox.Show("Error!", "Student Number field needs to be filled!");
            }
            if (Success == 1)
            {
                MessageBox.Show("Error!", "Check the Student Number field length!");
            }
            if (Success == 2)
            {
                MessageBox.Show("Error!", "Something went wrong. Please check that the field is entered correctly!");
            }
            if (Success == -1)
            {
                bool Successful = StudentClass.DeleteStudentDetails(tbStudentNumber.Text);
                if (Successful == false)
                {
                    MessageBox.Show("OOPS!", "Something went wrong!");
                }
                MessageBox.Show("Success!", "Student has been deleted successfully!");
                tbStudentNumber.Clear();
                tbStudentNumber.Focus();
            }
        }
    }
}
