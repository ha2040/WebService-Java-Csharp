using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using KebabUniService;
using System.Linq.Expressions;
using System.ServiceModel;
using WebServiceKebabUni.DTO;

namespace FormsControllers
{
    public partial class ResultForm : Form
    {
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);

        public ResultForm(string examId)
        {

            InitializeComponent();
            txtBoxExamId.Text = examId;
            FillStudentIdComboBox();

            resultDataGridView.AutoGenerateColumns = false;
            resultDataGridView.Columns.Add("StudentId", "Student ID");
            resultDataGridView.Columns.Add("Points", "Points");

            try
            {
                foreach (var result in kebabUniService.GetResults())
                {
                    if (result.Exam.ExamID.Equals(examId))
                    {
                        resultDataGridView.Rows.Add(result.Student.StudentId, result.Points);
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

        private void DeleteResultButton_Click(object sender, EventArgs e)
        {
            string studentId = txtBoxStudentID.Text;
            string examId = txtBoxExamId.Text;

            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please select a result to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                kebabUniService.DeleteResult(examId, studentId);
                resultDataGridView.Rows.Clear();
                foreach (var result in kebabUniService.GetResults())
                {
                    if (result.Exam.ExamID.Equals(examId))
                    {
                        resultDataGridView.Rows.Add(result.Student.StudentId, result.Points);
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

            txtBoxStudentID.Clear();
            txtBoxPoints.Clear();
        }

        private void FillStudentIdComboBox()
        {
            comboBoxStudent.DataSource = kebabUniService.GetStudents();
            comboBoxStudent.DisplayMember = "StudentId";
            comboBoxStudent.ValueMember = "StudentId";

        }

        private void AddResultButton_Click(object sender, EventArgs e)
        {
            string studentId = comboBoxStudent.Text;
            string examId = txtBoxExamId.Text;

            try
            {
                int points = int.Parse(txtBoxPoints.Text);
                kebabUniService.AddResult(examId, studentId, points);
                resultDataGridView.Rows.Clear();
                foreach (var result in kebabUniService.GetResults())
                {
                    if (result.Exam.ExamID.Equals(examId))
                    {
                        resultDataGridView.Rows.Add(result.Student.StudentId, result.Points);
                    }
                }

                txtBoxStudentID.Clear();
                txtBoxPoints.Clear();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FaultException faultEx)
            {
                if (faultEx.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show($"A result for this student already exists.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SystemException ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format."))
                {
                    MessageBox.Show($"Please enter only numeric values into the points field. Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured! Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }



        private void ResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.resultDataGridView.Rows[e.RowIndex];
                    txtBoxPoints.Text = row.Cells["Points"].Value.ToString();
                    txtBoxStudentID.Text = row.Cells["StudentID"].Value.ToString();
                    comboBoxStudent.Text = row.Cells["StudentID"].Value.ToString();
                }
                catch (NullReferenceException nullE) 
                {
                    txtBoxPoints.Clear();
                    txtBoxStudentID.Clear();
                }
            }
        }

        private void UpdateResult_Click(object sender, EventArgs e)
        {
            string studentId = txtBoxStudentID.Text;
            string examId = txtBoxExamId.Text;
            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please select a result to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int points = int.Parse(txtBoxPoints.Text);
                kebabUniService.UpdateResult(examId, studentId, points);
                resultDataGridView.Rows.Clear();
                foreach (var result in kebabUniService.GetResults())
                {
                    if (result.Exam.ExamID.Equals(examId))
                    {
                        resultDataGridView.Rows.Add(result.Student.StudentId, result.Points);
                    }
                }

                txtBoxStudentID.Clear();
                txtBoxPoints.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (SystemException ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format."))
                {
                    MessageBox.Show($"Please enter only numeric values into the points field. Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured! Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FaultException faultEx)
            {
                
                    MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


    }
}
