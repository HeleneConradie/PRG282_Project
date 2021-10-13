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
        public frmDisplay(searchType st)
        {
            InitializeComponent();

            _searchType = st;
        }

        BindingSource source = new BindingSource();
        searchType _searchType;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbSearch.Text;
            try
            {
                if (_searchType == "Module")
                {
                    foreach(Module item in source)
                    {
                        if (item.ModuleCode1 == id)
                        {
                            dgvDisplay.Rows.Clear();
                            dgvDisplay.Rows.Add(item.ModuleCode1, item.ModuleName1, item.ModuleDescription1, item.OnlineResources1);
                        }
                        else
                        {
                            throw new ExceptionHandling("The Module code that was entered does not exist");
                        }
                    }
                }
                else if (_searchType == "Student")
                {
                    foreach (Student item in source)
                    {
                        if (item.Studentnumber == id)
                        {
                            dgvDisplay.Rows.Clear();
                            dgvDisplay.Rows.Add(item.Studentnumber, item.StudentName, item.StudentMiddleName, item.StudentSurname, item.StudentImage, item.StudentDatOfBirth, item.StudentGender, item.StudentPhone, item.StudentAddress);
                        }
                        else
                        {
                            throw new ExceptionHandling("The Student Number that was entered does not exist");
                        }
                    }
                }
            }
            catch
            {
                throw new ExceptionHandling("An error has occured");
            }
        }

        public void frmDisplay_Load(object sender, EventArgs e)
        {
            if (_searchType == "Module")
            {
                Module mod = new Module();
                source.DataSource = mod.DisplayAll();
                dgvDisplay.DataSource = source;
            }
            else if (_searchType == "Student")
            {
                Student stu = new Student();
                source.DataSource = stu.DisplayAllStudents();
                dgvDisplay.DataSource = source;
            }
        }
    }
}
