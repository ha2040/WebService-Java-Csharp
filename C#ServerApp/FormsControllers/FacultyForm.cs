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
    public partial class FacultyForm : Form
    {
        KebabUniServiceSoapClient kebabUniService = new(KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap);
        public FacultyForm()
        {
            InitializeComponent();
            FacultyDataGridView.AutoGenerateColumns = false;
            FacultyDataGridView.Columns.Add("FacultyId", "Faculty ID");
            FacultyDataGridView.Columns.Add("FacultyName", "Faculty Name");
            FacultyDataGridView.Columns.Add("Address", "Address");

            try
            {
                foreach (var faculty in kebabUniService.GetFaculties())
                {
                    FacultyDataGridView.Rows.Add(faculty.FacultyId, faculty.FacultyName, faculty.Address);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddFaculty_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string address = txtBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Name and address cannot be empty. Please fill the fields.");
                return;
            }

            try
            {
                kebabUniService.AddFaculty(name, address);
                FacultyDataGridView.Rows.Clear();
                foreach (var faculty in kebabUniService.GetFaculties())
                {
                    FacultyDataGridView.Rows.Add(faculty.FacultyId, faculty.FacultyName, faculty.Address);
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
                    MessageBox.Show($"A Faculty with this ID already exists.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occured.\nError Message: {faultEx.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnUpdateFaculty_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string facultyId = txtBoxId.Text;
            string address = txtBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(facultyId))
            {
                MessageBox.Show("Please select a Faculty to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Name and address cannot be empty. Please fill the fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                kebabUniService.UpdateFaculty(facultyId, name, address);
                FacultyDataGridView.Rows.Clear();
                foreach (var faculty in kebabUniService.GetFaculties())
                {
                    FacultyDataGridView.Rows.Add(faculty.FacultyId, faculty.FacultyName, faculty.Address);
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

        private void BtnDeleteFaculty_Click(object sender, EventArgs e)
        {
            string facultyId = txtBoxId.Text;
            string name = txtBoxName.Text;
            string address = txtBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(facultyId))
            {
                MessageBox.Show("Please select a faculty to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                kebabUniService.DeleteFaculty(facultyId);
                FacultyDataGridView.Rows.Clear();
                foreach (var faculty in kebabUniService.GetFaculties())
                {
                    FacultyDataGridView.Rows.Add(faculty.FacultyId, faculty.FacultyName, faculty.Address);
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

        private void FacultyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.FacultyDataGridView.Rows[e.RowIndex];
                    txtBoxId.Text = row.Cells["FacultyID"].Value.ToString();
                    txtBoxName.Text = row.Cells["FacultyName"].Value.ToString();
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
