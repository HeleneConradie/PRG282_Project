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
using System.IO;

namespace DataSmart.Presentation_Layer
{
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();

        }

        BindingSource source = new BindingSource();
        Module mod = new Module();
        Student stu = new Student();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbSearch.Text;
            try
            {
                //if (_type == "Module")
                //{
                //    foreach(Module item in source)
                //    {
                //        if (item.ModuleCode1 == id)
                //        {
                //            dgvDisplay.Rows.Clear();
                //            dgvDisplay.Rows.Add(item.ModuleCode1, item.ModuleName1, item.ModuleDescription1, item.OnlineResources1);
                //        }
                //        else
                //        {
                //            throw new ExceptionHandling("The Module code that was entered does not exist");
                //        }
                //    }
                //}
                //else if (_type == "Student")
                //{
                //    foreach (Student item in source)
                //    {
                //        if (item.Studentnumber == id)
                //        {
                //            dgvDisplay.Rows.Clear();
                //            dgvDisplay.Rows.Add(item.Studentnumber, item.StudentName, item.StudentMiddleName, item.StudentSurname, item.StudentImage, item.StudentDatOfBirth, item.StudentGender, item.StudentPhone, item.StudentAddress);
                //        }
                //        else
                //        {
                //            throw new ExceptionHandling("The Student Number that was entered does not exist");
                //        }
                //    }
                //}
            }
            catch
            {
                throw new ExceptionHandling("An error has occured");
            }
        }

        public void displayModule()
        {
            source.DataSource = mod.DisplayAll();
            dgvDisplay.DataSource = source;
        }

        public void displayStudent()
        {
            source.DataSource = stu.DisplayAllStudents();
            dgvDisplay.DataSource = source;
        }
    }
}
