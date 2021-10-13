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
        public frmDisplay(string t)
        {
            InitializeComponent();
            TypeReceived = t;
        }

        BindingSource source = new BindingSource();
        Module mod = new Module();
        Student stu = new Student();
        frmMenu menuForm = new frmMenu();
        string TypeReceived;
        DataTable temp = new DataTable();


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeReceived == "Module")
                {
                    temp = mod.DisplaySearchedModule(tbSearch.Text);
                    source.DataSource = temp;
                    dgvDisplay.DataSource = source;
                }
                else if (TypeReceived == "Student")
                {
                    temp = stu.DisplaySearchedStudent(tbSearch.Text);
                    source.DataSource = temp;
                    dgvDisplay.DataSource = source;
                }
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

        private void frmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvDisplay.Rows[e.RowIndex];
                    Byte[] bytes = (Byte[])dgvDisplay.Rows[e.RowIndex].Cells["StudentImage"].Value;
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        pbStudentImageShow.Image = Image.FromStream(memoryStream);
                    }
                    //MemoryStream ms = new MemoryStream(bytes);
                    //pbStudentImageShow.Image = Image.FromStream(ms);


                    //if (row.Cells[5].Value != null)
                    //{
                    //    Byte[] imageData = new Byte[0];
                    //    imageData = (Byte[])row.Cells[5].Value;
                    //    MemoryStream ms = new MemoryStream(imageData);
                    //    pbStudentImageShow.Image = Image.FromStream(ms);
                    //}

                    //string StudNumber = row.Cells[0].Value.ToString();
                    //pbStudentImageShow.Image = row.Cells[5].Value as Image;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
