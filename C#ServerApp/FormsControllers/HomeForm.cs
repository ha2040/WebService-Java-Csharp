using KebabUniService;

namespace FormsControllers
{
    public partial class HomeForm : Form
    {
       
        
        public HomeForm()
        {
            InitializeComponent();
            var endpointConfiguration = KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap;

            KebabUniServiceSoapClient kebabUniService = new(endpointConfiguration);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //fungerar som initialize? om vi vill ha data som loadar direkt in när form skapas?
          

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
    }
}