using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KebabUniService;
using WebServiceKebabUni.DTO;

namespace FormsControllers
{
    public partial class ExamForm : Form
    {
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);
        public ExamForm()
        {
            InitializeComponent();
            FillCourseIdComboBox();

            examDataGridView.AutoGenerateColumns = false;
            examDataGridView.Columns.Add("ExamID", "Exam ID");
            examDataGridView.Columns.Add("CourseId", "Course ID");
            examDataGridView.Columns.Add("Room", "Room");
            examDataGridView.Columns.Add("ExamDate", "Exam Date");
            examDataGridView.Columns.Add("Credits", "Credits");
            try { 
            foreach (var exam in kebabUniService.GetExams())
            {
                examDataGridView.Rows.Add(exam.ExamID, exam.Course.CourseId, exam.Room, exam.ExamDate, exam.Credits);
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

            examDataGridView.CellEndEdit += ExamDataGridView_CellEndEdit;
            examDataGridView.CellBeginEdit += ExamDataGridView_CellBeginEdit;

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

        private void FillCourseIdComboBox()
        {
            comboBox1.DataSource = kebabUniService.GetCourses();
            comboBox1.DisplayMember = "CourseId";
            comboBox1.ValueMember = "CourseId";
        }

        private void BtnAddExam(object sender, EventArgs e)
        {
            string room = txtBoxRoomId.Text;
            string courseId = comboBox1.Text;
            DateTime dateTime = dateTimePicker1.Value;


            try
            {
                int credits = int.Parse(creditTextBox.Text);
                kebabUniService.AddExam(courseId, room, dateTime, credits);
                examDataGridView.Rows.Clear();
                foreach (var exam in kebabUniService.GetExams())
                {
                    examDataGridView.Rows.Add(exam.ExamID, exam.Course.CourseId, exam.Room, exam.ExamDate, exam.Credits);
                }

                txtBoxRoomId.Clear();
                creditTextBox.Clear();
                txtBoxId.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException faultEx)
            {
                if (faultEx.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show($"An Exam with this ID already exists.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SystemException ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format."))
                {
                    MessageBox.Show($"Please enter only numeric values into the credits field. Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured! Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ExamDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.examDataGridView.Rows[e.RowIndex];
                    txtBoxId.Text = row.Cells["ExamId"].Value.ToString();
                    txtBoxRoomId.Text = row.Cells["Room"].Value.ToString();
                    comboBox1.Text = row.Cells["CourseId"].Value.ToString();
                    creditTextBox.Text = row.Cells["Credits"].Value.ToString();
                    DateTime dateValue = Convert.ToDateTime(row.Cells["ExamDate"].Value);
                    dateTimePicker1.Value = dateValue;
                }
                catch (NullReferenceException nullE)
                {
                    txtBoxId.Clear();
                    txtBoxRoomId.Clear();
                    creditTextBox.Clear();
                }

            }
        }

        private void BtnUpdateExam(object sender, EventArgs e)
        {
            string room = txtBoxRoomId.Text;
            string courseId = comboBox1.Text;
            string examId = txtBoxId.Text;
            DateTime dateTime = dateTimePicker1.Value;

            try
            {
                int credits = Int32.Parse(creditTextBox.Text);
                kebabUniService.UpdateExam(examId, courseId, room, dateTime, credits);
                examDataGridView.Rows.Clear();
                foreach (var exam in kebabUniService.GetExams())
                {
                    examDataGridView.Rows.Add(exam.ExamID, exam.Course.CourseId, exam.Room, exam.ExamDate, exam.Credits);
                }

                txtBoxRoomId.Clear();
                creditTextBox.Clear();
                txtBoxId.Clear();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemException ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format."))
                {
                    MessageBox.Show($"Please enter only numeric values into the credits field. Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnDeleteExam(object sender, EventArgs e)
        {
            string examId = txtBoxId.Text;
            if (txtBoxId.Text == "")
            {
                MessageBox.Show("This exam does either not exist or cannot be found.");
            }
            else

            {
                try
                {
                    kebabUniService.DeleteExam(examId);
                    examDataGridView.Rows.Clear();
                    foreach (var exam in kebabUniService.GetExams())
                    {
                        examDataGridView.Rows.Add(exam.ExamID, exam.Course.CourseId, exam.Room, exam.ExamDate, exam.Credits);
                    }
                    txtBoxId.Clear();
                    txtBoxRoomId.Clear();
                    creditTextBox.Clear();
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
        }

        private void ExamDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = examDataGridView.Rows[e.RowIndex];
            DataRowView editedDataRow = (DataRowView)editedRow.DataBoundItem;
            string examID = editedDataRow["ExamID"].ToString();
            string courseId = editedDataRow["CourseId"].ToString();
            string room = editedDataRow["Room"].ToString();
            DateTime dateTime = (DateTime)editedDataRow["ExamDate"];
            int credits = (int)editedDataRow["Credits"];

            kebabUniService.UpdateExam(examID, courseId, room, dateTime, credits);
            examDataGridView.Rows.Clear();
            foreach (var exam in kebabUniService.GetExams())
            {
                examDataGridView.Rows.Add(exam.ExamID, exam.Course.CourseId, exam.Room, exam.ExamDate, exam.Credits);
            }
        }

        private void ExamDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string columnName = examDataGridView.Columns[e.ColumnIndex].Name;
            if (columnName == "ExamID" || columnName == "CourseID" || columnName == "ExamDate")
            {
                e.Cancel = true;
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            string examId = txtBoxId.Text;
            if (!string.IsNullOrEmpty(examId))
            {
                this.Hide();
                ResultForm resultForm = new ResultForm(examId);
                resultForm.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Please select an exam to view results in.");
                return;
            }


        }

    }
}
