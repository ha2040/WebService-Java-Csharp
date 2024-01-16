using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Windows.Forms;
using KebabUniService;
using System.ServiceModel;
using WebServiceKebabUni.DTO;

namespace FormsControllers
{
   
    public partial class StudentStudyForm : Form
    {
        
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);
        private DateTime originalStartDate;
        public StudentStudyForm(string courseId)
        {

            InitializeComponent();
            txtBoxCourseId.Text = courseId;
            FillStudentIdComboBox();

            StudentStudyDataGridView.AutoGenerateColumns = false;
            StudentStudyDataGridView.Columns.Add("StudentId", "Student ID");
            StudentStudyDataGridView.Columns.Add("StartDate", "Start Date");
            StudentStudyDataGridView.Columns.Add("EndDate", "End Date");

            try
            {
                foreach (var studentStudy in kebabUniService.GetStudentStudy())
                {
                    if (studentStudy.Course.CourseId.Equals(courseId))
                    {
                        StudentStudyDataGridView.Rows.Add(studentStudy.Student.StudentId, studentStudy.StartDate, studentStudy.EndDate);
                    }

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.ShowDialog();
            this.Close();

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
            this.Close();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm examForm = new ExamForm();
            examForm.ShowDialog();
            this.Close();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            this.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentsForm = new StudentForm();
            studentsForm.ShowDialog();
            this.Close();
        }
        private void FillStudentIdComboBox()
        {
            comboBoxStudent.DataSource = kebabUniService.GetStudents();
            comboBoxStudent.DisplayMember = "StudentId";
            comboBoxStudent.ValueMember = "StudentId";

        }

        private void StudentStudyForm_Load(object sender, EventArgs e)
        {

        }
       
        private void StudentStudyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.StudentStudyDataGridView.Rows[e.RowIndex];
                    txtBoxStudentId.Text = row.Cells["StudentId"].Value.ToString();
                    comboBoxStudent.Text = row.Cells["StudentID"].Value.ToString();
                    DateTime startDate= Convert.ToDateTime(row.Cells["StartDate"].Value);
                    DateTime endDate = Convert.ToDateTime(row.Cells["EndDate"].Value);
                    datePickerStartDate.Value = startDate;
                    datePickerEndDate.Value = endDate;
                    originalStartDate = startDate;
                }
                catch (NullReferenceException nullE)
                {
                   
                    txtBoxStudentId.Clear();
                }
            }
        }

        private void BtnAddStudentStudy_Click(object sender, EventArgs e)
        {
            string studentId = comboBoxStudent.Text;
            string courseId = txtBoxCourseId.Text;
            DateTime startDate = datePickerStartDate.Value;
            DateTime endDate = datePickerEndDate.Value;


            DateTime endDateInput = startDate.AddMonths(6);
            try
            {
                kebabUniService.AddStudentStudy(courseId, studentId, startDate, endDateInput);
                StudentStudyDataGridView.Rows.Clear();
                foreach (var studentStudy in kebabUniService.GetStudentStudy())
                {
                    if (studentStudy.Course.CourseId.Equals(courseId))
                    {
                        StudentStudyDataGridView.Rows.Add(studentStudy.Student.StudentId, studentStudy.StartDate, studentStudy.EndDate);
                    }
                }

                txtBoxStudentId.Clear();

            }
            catch (SqlException sqlE)
            {

                MessageBox.Show(UniversalMethods.SqlErrors(sqlE.Message, sqlE), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (SoapException soapEx)
            {
                if (soapEx.Message.Contains("Violation of PRIMARY KEY constraint"))
                {


                    MessageBox.Show($"This course for this student already exists.\nError Message: {soapEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show($"An error has occured..\nError Message: {soapEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FaultException faultEx) 
            {
                if (faultEx.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show($"This course for this student already exists.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            }

        private void BtnUpdateStudentStudy_Click(object sender, EventArgs e)
        {
            string studentId = txtBoxStudentId.Text;
            string courseId = txtBoxCourseId.Text;
            DateTime startDate = datePickerStartDate.Value;
            DateTime endDate = datePickerEndDate.Value;


            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                kebabUniService.UpdateStudentStudy(courseId, studentId, originalStartDate, endDate);
                StudentStudyDataGridView.Rows.Clear();
                foreach (var studentStudy in kebabUniService.GetStudentStudy())
                {
                    if (studentStudy.Course.CourseId.Equals(courseId))
                    {
                        StudentStudyDataGridView.Rows.Add(studentStudy.Student.StudentId, studentStudy.StartDate, studentStudy.EndDate);
                    }
                }

                txtBoxStudentId.Clear();

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

        private void BtnDeleteStudentStudy_Click(object sender, EventArgs e)
        {
            string studentId = txtBoxStudentId.Text;
            string courseId = txtBoxCourseId.Text;

            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                kebabUniService.DeleteStudentStudy(studentId, courseId);
                StudentStudyDataGridView.Rows.Clear();
                foreach (var studentStudy in kebabUniService.GetStudentStudy())
                {
                    if (studentStudy.Course.CourseId.Equals(courseId))
                    {
                        StudentStudyDataGridView.Rows.Add(studentStudy.Student.StudentId, studentStudy.StartDate, studentStudy.EndDate);
                    }

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
            txtBoxStudentId.Clear();

        }

    }
    
}
