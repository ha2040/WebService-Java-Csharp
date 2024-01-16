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
    public partial class CourseForm : Form
    {
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);
        public CourseForm()
        {
            InitializeComponent();

            CourseDataGridView.AutoGenerateColumns = false;
            CourseDataGridView.Columns.Add("CourseId", "Course ID");
            CourseDataGridView.Columns.Add("FacultyId", "Faculty ID");
            CourseDataGridView.Columns.Add("Credits", "Credits");
            CourseDataGridView.Columns.Add("Description", "Description");
            CourseDataGridView.Columns.Add("EmpId", "Emp ID");
            try
            {
                FillFacultyComboBox();
                FillEmployeeComboBox();
                var courses = kebabUniService.GetCourses();
                foreach (var course in courses)
                {
                    CourseDataGridView.Rows.Add(course.CourseId, course.Faculty.FacultyId, course.Credits, course.Description, course.Employee.EmpId);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show (UniversalMethods.SqlErrors(ex.Message, ex),"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CourseForm_Load(object sender, EventArgs e)
        {


        }

        private void FillFacultyComboBox()
        {
            FacultyComboBox.ValueMember = "FacultyId";
            FacultyComboBox.DataSource = kebabUniService.GetFaculties();
            FacultyComboBox.DisplayMember = "FacultyId";
        }
        private void FillEmployeeComboBox()
        {
            EmployeeComboBox.ValueMember = "EmpId";
            EmployeeComboBox.DataSource = kebabUniService.GetEmployees();
            EmployeeComboBox.DisplayMember = "EmpId";
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            string description = courseDescriptionTextBox.Text;
            string empId = EmployeeComboBox.Text;
            string facultyId = FacultyComboBox.Text;
            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(courseCreditTextBox.Text)) 
            {
                MessageBox.Show("Please fill all the fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
                try
                {
                    int credits = int.Parse(courseCreditTextBox.Text);
                    kebabUniService.AddCourse(facultyId, credits, description, empId);
                    CourseDataGridView.Rows.Clear();
                    foreach (var course in kebabUniService.GetCourses())
                    {
                        CourseDataGridView.Rows.Add(course.CourseId, course.Faculty.FacultyId, course.Credits, course.Description, course.Employee.EmpId);
                    }

                    courseIdTextBox.Clear();
                    courseCreditTextBox.Clear();
                    courseDescriptionTextBox.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FaultException faultEx)
                {
                    if (faultEx.Message.Contains("Violation of PRIMARY KEY constraint"))
                    {
                        MessageBox.Show($"A course with this ID already exists.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text;
            kebabUniService.DeleteCourse(courseId);
            CourseDataGridView.Rows.Clear();

            if (string.IsNullOrWhiteSpace(courseId))
            {
                MessageBox.Show("Please select a course to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try { 
            foreach (var course in kebabUniService.GetCourses())
            {
                CourseDataGridView.Rows.Add(course.CourseId, course.Faculty.FacultyId, course.Credits, course.Description, course.Employee.EmpId);
            }

            courseIdTextBox.Clear();
            courseCreditTextBox.Clear();
            courseDescriptionTextBox.Clear();
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
      

        private void UpdateCourseButton_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text;
            string facultyId = FacultyComboBox.Text;          
            string description = courseDescriptionTextBox.Text;
            string empId = EmployeeComboBox.Text;

            try
            {
                int credits = int.Parse(courseCreditTextBox.Text);
                kebabUniService.UpdateCourse(courseId, facultyId, credits, description, empId);
                CourseDataGridView.Rows.Clear();
                foreach (var course in kebabUniService.GetCourses())
                {
                    CourseDataGridView.Rows.Add(course.CourseId, course.Faculty.FacultyId, course.Credits, course.Description, course.Employee.EmpId);
                }

                courseIdTextBox.Clear();
                courseCreditTextBox.Clear();
                courseDescriptionTextBox.Clear();
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
    

        private void CourseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.CourseDataGridView.Rows[e.RowIndex];
                    courseIdTextBox.Text = row.Cells["CourseId"].Value.ToString();
                    courseCreditTextBox.Text = row.Cells["Credits"].Value.ToString();
                    courseDescriptionTextBox.Text = row.Cells["Description"].Value.ToString();
                    FacultyComboBox.Text = row.Cells["FacultyId"].Value.ToString();
                    EmployeeComboBox.Text = row.Cells["EmpId"].Value.ToString();
                }
                catch (NullReferenceException nullRef)
                {
                    courseIdTextBox.Clear();
                    courseCreditTextBox.Clear();
                    courseDescriptionTextBox.Clear();
                }
            }
        }

        private void BtnToStudentStudy_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text;
            if (!string.IsNullOrEmpty(courseId))
            {
                this.Hide();
                StudentStudyForm studentStudyForm = new StudentStudyForm(courseId);
                studentStudyForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an Course to view results in.");
                return;
            }
        }
    }
}
