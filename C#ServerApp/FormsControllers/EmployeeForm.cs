using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FormsControllers;
using KebabUniService;
using WebServiceKebabUni.DTO;

namespace FormsControllers
{

    public  partial class EmployeeForm : Form
    {
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);

       
        public EmployeeForm()
        {
            InitializeComponent();
            FillFacultyComboBox();
            EmployeeDataGridView.AutoGenerateColumns = false;
            EmployeeDataGridView.Columns.Add("EmpId", "Employee ID");
            EmployeeDataGridView.Columns.Add("EmployeeName", "Employee Name");
            EmployeeDataGridView.Columns.Add("Salary", "Salary");
            EmployeeDataGridView.Columns.Add("FacultyId", "Faculty ID");

            try
            {
                var employees = kebabUniService.GetEmployees();
                foreach (var employee in employees)
                {
                    var facultyId = employee.Faculty?.FacultyId;
                    EmployeeDataGridView.Rows.Add(employee.EmpId, employee.EmployeeName, employee.Salary, facultyId);
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

        private void FillFacultyComboBox()
        {
            comboBoxFaculty.DisplayMember = "FacultyId";
            comboBoxFaculty.ValueMember = "FacultyId";

            List<FacultyDTO> faculties = kebabUniService.GetFaculties();

            comboBoxFaculty.DataSource = faculties;
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {

            string empName = txtBoxName.Text;
            string facultyId = comboBoxFaculty.Text;
            string salaryString = txtBoxSalary.Text;


            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(salaryString))
            {
                MessageBox.Show("Name and salary cannot be empty. Please fill the fields.");
                return;
            }
            if (!Regex.IsMatch(empName, @"^[a-zA-ZåäöÅÄÖ ]+$"))
            {
                MessageBox.Show("Name can only consist of alphabetic characters");
                return;

            }
            try
            {
                int salary = Int32.Parse(salaryString);

                kebabUniService.AddEmployee(empName, salary, facultyId);
                txtBoxName.Clear();
                TxtBoxId.Clear();
                txtBoxSalary.Clear();
                FillDataGridView();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemException ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format."))
                {
                    MessageBox.Show($"Please enter only numeric values into the salary field. Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured! Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string empId = TxtBoxId.Text;
            string facultyId = comboBoxFaculty.Text;
            string salaryString = txtBoxSalary.Text;

            if (string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("Please select a Employee to Update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(txtBoxSalary.Text))
            {
                MessageBox.Show("Name and salary cannot be empty. Please fill the fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(name, @"^[a-zA-ZåäöÅÄÖ ]+$"))
            {
                MessageBox.Show("Name can only consist of alphabetic characters");
                return;

            }
            try
            {
                int salary = Int32.Parse(salaryString);

                kebabUniService.UpdateEmployee(empId,name, salary,facultyId);
                FillDataGridView();
                txtBoxName.Clear();
                TxtBoxId.Clear();
                txtBoxSalary.Clear();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(UniversalMethods.SqlErrors(ex.Message, ex), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemException ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format."))
                {
                    MessageBox.Show($"Please enter only numeric values into the salary field. Error Message: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string empId = TxtBoxId.Text;
            if (string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("Please select an Employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                kebabUniService.DeleteEmployee(empId);
                txtBoxName.Clear();
                TxtBoxId.Clear();
                txtBoxSalary.Clear();
                FillDataGridView();
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






        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try { 
                DataGridViewRow row = this.EmployeeDataGridView.Rows[e.RowIndex];
                TxtBoxId.Text = row.Cells["EmpId"].Value.ToString();
                txtBoxName.Text = row.Cells["EmployeeName"].Value.ToString();
                comboBoxFaculty.Text = row.Cells["FacultyId"].Value.ToString();
                txtBoxSalary.Text = row.Cells["Salary"].Value.ToString();
                }
                catch (NullReferenceException nullE)
                {
                    txtBoxName.Clear();
                    TxtBoxId.Clear();
                    txtBoxSalary.Clear();
                }
            }

        }
        private void FillDataGridView()
        {
            EmployeeDataGridView.Rows.Clear(); // Clear existing rows
            var employees = kebabUniService.GetEmployees();
            foreach (var employee in employees)
            {
                var facultyId = employee.Faculty?.FacultyId;
                EmployeeDataGridView.Rows.Add(employee.EmpId, employee.EmployeeName, employee.Salary, facultyId);
            }
        }



    }
}



