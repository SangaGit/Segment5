using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;

namespace WindowsFormsApplication_Segment5_
{
    public partial class FormAllStudents : Form
    {
        private BindingList<Student> studentList = new BindingList<Student>();
        private StudentRegister register = new StudentRegister();
        public FormAllStudents()
        {
            InitializeComponent();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormAddNew(this).Show();
            this.Hide();
        }

        public void AddStudentToGrid(string name, DateTime dob, decimal gpa, bool active)
        {
            studentList.Add(new Student
            {
                ID = 0,
                Name = name,
                DOB = dob,
                GradePointAverage = gpa,
                IsActive = active
            });
        }

        private void FormAllStudents_Load(object sender, EventArgs e)
        {
            studentList = new BindingList<Student>(register.GetAllStudents());
            GridViewDetais.DataSource = studentList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.register.SaveStudents(this.studentList.ToList());
            studentList = new BindingList<Student>(register.GetAllStudents());
            GridViewDetais.DataSource = studentList;
            MessageBox.Show("Successfully Saved.");
        }
    }
}
