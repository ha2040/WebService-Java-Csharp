using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using KebabUniService;
using WebServiceKebabUni.DTO;

namespace FormsControllers
{
    public partial class StudentForm : Form
    {
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);
        public StudentForm()
        {
            InitializeComponent();
            StudentDataGridView.AutoGenerateColumns = false;
            StudentDataGridView.Columns.Add("StudentId", "Student ID");
            StudentDataGridView.Columns.Add("StudentName", "Student Name");
            StudentDataGridView.Columns.Add("Address", "Address");
         
            try
            { 
                foreach (var student in kebabUniService.GetStudents())
                {
                    StudentDataGridView.Rows.Add(student.StudentId, student.StudentName, student.Address);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException faultEx)
            {
                MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void BtnFaculty_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.ShowDialog();
            this.Close();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            this.Close();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
            this.Close();
        }

        private void BtnExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm examForm = new ExamForm();
            examForm.ShowDialog();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }
        private void BtnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentsForm = new StudentForm();
            studentsForm.ShowDialog();
            this.Close();
        }

        private void BtnAddStudent(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string address = txtBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Name and address cannot be empty. Please fill the fields.");
                return;
            }
            if (!Regex.IsMatch(name, @"^[a-zA-ZåäöÅÄÖ ]+$"))
            {
                MessageBox.Show("Name can only consist of alphabetic characters");
                return;

            }
            try
            {
                kebabUniService.AddStudent(name, address);
                StudentDataGridView.Rows.Clear();
                foreach (var student in kebabUniService.GetStudents())
                {
                    StudentDataGridView.Rows.Add(student.StudentId, student.StudentName, student.Address);
                }

                txtBoxName.Clear();
                txtBoxId.Clear();
                txtBoxAddress.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException faultEx)
            {
                if (faultEx.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show($"A student with this ID already exists.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured.\nError Message {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnUpdateStudent(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string studentId = txtBoxId.Text;
            string address = txtBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Please select a student to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Name and address cannot be empty. Please fill the fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(name, @"^[a-zA-ZåäöÅÄÖ ]+$"))
            {
                MessageBox.Show("Name can only consist of alphabetic characters");
                return;

            }


            try
            {
                kebabUniService.UpdateStudent(studentId, name, address);
                StudentDataGridView.Rows.Clear();
                foreach (var student in kebabUniService.GetStudents())
                {
                    StudentDataGridView.Rows.Add(student.StudentId, student.StudentName, student.Address);
                }

                txtBoxName.Clear();
                txtBoxId.Clear();
                txtBoxAddress.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException faultEx)
            {
                MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }

        }

        private void BtnDeleteStudent(object sender, EventArgs e)
        {
            string studentId = txtBoxId.Text;
            string name = txtBoxName.Text;
            string address = txtBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                kebabUniService.DeleteStudent(studentId);
                StudentDataGridView.Rows.Clear();
                foreach (var student in kebabUniService.GetStudents())
                {
                    StudentDataGridView.Rows.Add(student.StudentId, student.StudentName, student.Address);
                }

                txtBoxName.Clear();
                txtBoxId.Clear();
                txtBoxAddress.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException faultEx)
            {
                 MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
        }

        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.StudentDataGridView.Rows[e.RowIndex];
                    txtBoxId.Text = row.Cells["StudentID"].Value.ToString();
                    txtBoxName.Text = row.Cells["StudentName"].Value.ToString();
                    txtBoxAddress.Text = row.Cells["Address"].Value.ToString();
                }
                catch (NullReferenceException nullE) 
                {
                    txtBoxId.Clear();
                    txtBoxName.Clear();
                    txtBoxAddress.Clear();
                }
            }
        }
    }
}

