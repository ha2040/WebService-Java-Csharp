namespace FormsControllers
{
    partial class StudentStudyForm
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.StudentStudyDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.txtBoxCourseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.BtnAddStudentStudy = new System.Windows.Forms.Button();
            this.BtnUpdateStudentStudy = new System.Windows.Forms.Button();
            this.BtnDeleteStudentStudy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentStudyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(132, 66);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.Location = new System.Drawing.Point(0, 73);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(132, 66);
            this.btnFaculty.TabIndex = 1;
            this.btnFaculty.Text = "Faculty";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(0, 136);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(132, 66);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(0, 199);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(132, 66);
            this.btnExam.TabIndex = 3;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(0, 262);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(132, 66);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(0, 324);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(132, 66);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // StudentStudyDataGridView
            // 
            this.StudentStudyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentStudyDataGridView.Location = new System.Drawing.Point(378, 12);
            this.StudentStudyDataGridView.Name = "StudentStudyDataGridView";
            this.StudentStudyDataGridView.ReadOnly = true;
            this.StudentStudyDataGridView.RowTemplate.Height = 25;
            this.StudentStudyDataGridView.Size = new System.Drawing.Size(410, 240);
            this.StudentStudyDataGridView.TabIndex = 6;
            this.StudentStudyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentStudyDataGridView_CellClick);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(333, 324);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent.TabIndex = 7;
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.Location = new System.Drawing.Point(333, 353);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(200, 23);
            this.datePickerStartDate.TabIndex = 8;
            // 
            // datePickerEndDate
            // 
            this.datePickerEndDate.Location = new System.Drawing.Point(333, 382);
            this.datePickerEndDate.Name = "datePickerEndDate";
            this.datePickerEndDate.Size = new System.Drawing.Size(200, 23);
            this.datePickerEndDate.TabIndex = 9;
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Enabled = false;
            this.txtBoxStudentId.Location = new System.Drawing.Point(688, 258);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.PlaceholderText = "StudendId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxStudentId.TabIndex = 10;
            // 
            // txtBoxCourseId
            // 
            this.txtBoxCourseId.Enabled = false;
            this.txtBoxCourseId.Location = new System.Drawing.Point(582, 258);
            this.txtBoxCourseId.Name = "txtBoxCourseId";
            this.txtBoxCourseId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCourseId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Course:";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(272, 361);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(55, 15);
            this.StartDate.TabIndex = 13;
            this.StartDate.Text = "StartDate";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(276, 390);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(51, 15);
            this.endDate.TabIndex = 14;
            this.endDate.Text = "EndDate";
            // 
            // BtnAddStudentStudy
            // 
            this.BtnAddStudentStudy.Location = new System.Drawing.Point(555, 326);
            this.BtnAddStudentStudy.Name = "BtnAddStudentStudy";
            this.BtnAddStudentStudy.Size = new System.Drawing.Size(75, 23);
            this.BtnAddStudentStudy.TabIndex = 15;
            this.BtnAddStudentStudy.Text = "Add";
            this.BtnAddStudentStudy.UseVisualStyleBackColor = true;
            this.BtnAddStudentStudy.Click += new System.EventHandler(this.BtnAddStudentStudy_Click);
            // 
            // BtnUpdateStudentStudy
            // 
            this.BtnUpdateStudentStudy.Location = new System.Drawing.Point(555, 355);
            this.BtnUpdateStudentStudy.Name = "BtnUpdateStudentStudy";
            this.BtnUpdateStudentStudy.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateStudentStudy.TabIndex = 16;
            this.BtnUpdateStudentStudy.Text = "Update";
            this.BtnUpdateStudentStudy.UseVisualStyleBackColor = true;
            this.BtnUpdateStudentStudy.Click += new System.EventHandler(this.BtnUpdateStudentStudy_Click);
            // 
            // BtnDeleteStudentStudy
            // 
            this.BtnDeleteStudentStudy.Location = new System.Drawing.Point(555, 384);
            this.BtnDeleteStudentStudy.Name = "BtnDeleteStudentStudy";
            this.BtnDeleteStudentStudy.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteStudentStudy.TabIndex = 17;
            this.BtnDeleteStudentStudy.Text = "Delete";
            this.BtnDeleteStudentStudy.UseVisualStyleBackColor = true;
            this.BtnDeleteStudentStudy.Click += new System.EventHandler(this.BtnDeleteStudentStudy_Click);
            // 
            // StudentStudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteStudentStudy);
            this.Controls.Add(this.BtnUpdateStudentStudy);
            this.Controls.Add(this.BtnAddStudentStudy);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCourseId);
            this.Controls.Add(this.txtBoxStudentId);
            this.Controls.Add(this.datePickerEndDate);
            this.Controls.Add(this.datePickerStartDate);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.StudentStudyDataGridView);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnHome);
            this.Name = "StudentStudyForm";
            this.Text = "StudentStudyForm";
            this.Load += new System.EventHandler(this.StudentStudyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentStudyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHome;
        private Button btnFaculty;
        private Button btnCourse;
        private Button btnExam;
        private Button btnEmployee;
        private Button btnStudent;
        private DataGridView StudentStudyDataGridView;
        private ComboBox comboBoxStudent;
        private DateTimePicker datePickerStartDate;
        private DateTimePicker datePickerEndDate;
        private TextBox txtBoxStudentId;
        private TextBox txtBoxCourseId;
        private Label label1;
        private Label StartDate;
        private Label endDate;
        private Button BtnAddStudentStudy;
        private Button BtnUpdateStudentStudy;
        private Button BtnDeleteStudentStudy;
    }
}