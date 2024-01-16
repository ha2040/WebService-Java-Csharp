namespace FormsControllers
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.DeleteCourseButton = new System.Windows.Forms.Button();
            this.UpdateCourseButton = new System.Windows.Forms.Button();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.courseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnToStudentStudy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnFaculty);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 450);
            this.panel1.TabIndex = 13;
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(0, 345);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(132, 66);
            this.btnStudent.TabIndex = 9;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(0, 223);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(132, 66);
            this.btnExam.TabIndex = 7;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.BtnExam_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 43);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(132, 66);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.Location = new System.Drawing.Point(0, 104);
            this.btnFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(132, 66);
            this.btnFaculty.TabIndex = 4;
            this.btnFaculty.Text = "Faculty";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.BtnFaculty_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(0, 286);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(132, 66);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(0, 163);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(132, 66);
            this.btnCourse.TabIndex = 6;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.BtnCourse_Click);
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGridView.Location = new System.Drawing.Point(251, 20);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.RowTemplate.Height = 25;
            this.CourseDataGridView.Size = new System.Drawing.Size(550, 289);
            this.CourseDataGridView.TabIndex = 10;
            this.CourseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGridView_CellClick);
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(314, 404);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(121, 23);
            this.EmployeeComboBox.TabIndex = 14;
            this.EmployeeComboBox.Text = "Employee";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(314, 316);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(121, 23);
            this.FacultyComboBox.TabIndex = 15;
            this.FacultyComboBox.Text = "Faculty";
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(441, 315);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 16;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // DeleteCourseButton
            // 
            this.DeleteCourseButton.Location = new System.Drawing.Point(441, 374);
            this.DeleteCourseButton.Name = "DeleteCourseButton";
            this.DeleteCourseButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCourseButton.TabIndex = 17;
            this.DeleteCourseButton.Text = "Delete";
            this.DeleteCourseButton.UseVisualStyleBackColor = true;
            this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
            // 
            // UpdateCourseButton
            // 
            this.UpdateCourseButton.Location = new System.Drawing.Point(441, 345);
            this.UpdateCourseButton.Name = "UpdateCourseButton";
            this.UpdateCourseButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateCourseButton.TabIndex = 18;
            this.UpdateCourseButton.Text = "Update";
            this.UpdateCourseButton.UseVisualStyleBackColor = true;
            this.UpdateCourseButton.Click += new System.EventHandler(this.UpdateCourseButton_Click);
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Enabled = false;
            this.courseIdTextBox.Location = new System.Drawing.Point(666, 315);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.PlaceholderText = "ID";
            this.courseIdTextBox.ReadOnly = true;
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.courseIdTextBox.TabIndex = 20;
            // 
            // courseDescriptionTextBox
            // 
            this.courseDescriptionTextBox.Location = new System.Drawing.Point(314, 375);
            this.courseDescriptionTextBox.Name = "courseDescriptionTextBox";
            this.courseDescriptionTextBox.PlaceholderText = "Name";
            this.courseDescriptionTextBox.Size = new System.Drawing.Size(121, 23);
            this.courseDescriptionTextBox.TabIndex = 21;
            // 
            // courseCreditTextBox
            // 
            this.courseCreditTextBox.Location = new System.Drawing.Point(314, 346);
            this.courseCreditTextBox.Name = "courseCreditTextBox";
            this.courseCreditTextBox.PlaceholderText = "Credits";
            this.courseCreditTextBox.Size = new System.Drawing.Size(121, 23);
            this.courseCreditTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // BtnToStudentStudy
            // 
            this.BtnToStudentStudy.Location = new System.Drawing.Point(642, 415);
            this.BtnToStudentStudy.Name = "BtnToStudentStudy";
            this.BtnToStudentStudy.Size = new System.Drawing.Size(151, 23);
            this.BtnToStudentStudy.TabIndex = 24;
            this.BtnToStudentStudy.Text = "Add Students To Course";
            this.BtnToStudentStudy.UseVisualStyleBackColor = true;
            this.BtnToStudentStudy.Click += new System.EventHandler(this.BtnToStudentStudy_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnToStudentStudy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseCreditTextBox);
            this.Controls.Add(this.courseDescriptionTextBox);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.UpdateCourseButton);
            this.Controls.Add(this.DeleteCourseButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.EmployeeComboBox);
            this.Controls.Add(this.CourseDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnStudent;
        private Button btnExam;
        private Button btnHome;
        private Button btnFaculty;
        private Button btnEmployee;
        private Button btnCourse;
        private DataGridView CourseDataGridView;
        private ComboBox EmployeeComboBox;
        private ComboBox FacultyComboBox;
        private Button AddCourseButton;
        private Button DeleteCourseButton;
        private Button UpdateCourseButton;
        private TextBox courseIdTextBox;
        private TextBox courseDescriptionTextBox;
        private TextBox courseCreditTextBox;
        private Label label1;
        private Button BtnToStudentStudy;
    }
}