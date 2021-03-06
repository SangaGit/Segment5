﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Segment5_
{
    public partial class FormAddNew : Form
    {
        private FormAllStudents frmAllStudents;
        public FormAddNew(FormAllStudents frm)
        {
            this.frmAllStudents = frm;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmAllStudents.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                MessageBox.Show("Please enter student name.");
                return;
            }
            if (mtxtGPA.Text.Trim() == ".")
            {
                MessageBox.Show("Please enter student GPA.");
                return;
            }
            this.frmAllStudents.AddStudentToGrid(txtStudentName.Text, dtpDOB.Value, decimal.Parse(mtxtGPA.Text), chkActive.Checked);
            this.frmAllStudents.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
