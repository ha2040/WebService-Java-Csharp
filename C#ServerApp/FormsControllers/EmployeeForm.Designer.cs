namespace FormsControllers
{
    partial class EmployeeForm
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
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.BtnInsertEmployee = new System.Windows.Forms.Button();
            this.BtnUpdateEmployee = new System.Windows.Forms.Button();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(322, 44);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 25;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(475, 309);
            this.EmployeeDataGridView.TabIndex = 10;
            this.EmployeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellClick);
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.BtnAddEmployee.TabIndex = 21;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(157, 388);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.PlaceholderText = "Salary";
            this.txtBoxSalary.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSalary.TabIndex = 12;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(157, 360);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Name";
            this.txtBoxName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxName.TabIndex = 13;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(157, 417);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFaculty.TabIndex = 15;
            this.comboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaculty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 15;
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
            this.panel1.TabIndex = 18;
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
            // TxtBoxId
            // 
            this.TxtBoxId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TxtBoxId.Enabled = false;
            this.TxtBoxId.Location = new System.Drawing.Point(688, 360);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.PlaceholderText = "ID";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxId.TabIndex = 22;
            // 
            // BtnInsertEmployee
            // 
            this.BtnInsertEmployee.Location = new System.Drawing.Point(296, 388);
            this.BtnInsertEmployee.Name = "BtnInsertEmployee";
            this.BtnInsertEmployee.Size = new System.Drawing.Size(116, 23);
            this.BtnInsertEmployee.TabIndex = 23;
            this.BtnInsertEmployee.Text = "Add Employee";
            this.BtnInsertEmployee.UseVisualStyleBackColor = true;
            this.BtnInsertEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // BtnUpdateEmployee
            // 
            this.BtnUpdateEmployee.Location = new System.Drawing.Point(296, 417);
            this.BtnUpdateEmployee.Name = "BtnUpdateEmployee";
            this.BtnUpdateEmployee.Size = new System.Drawing.Size(116, 23);
            this.BtnUpdateEmployee.TabIndex = 24;
            this.BtnUpdateEmployee.Text = "Update Employee";
            this.BtnUpdateEmployee.UseVisualStyleBackColor = true;
            this.BtnUpdateEmployee.Click += new System.EventHandler(this.BtnUpdateEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(296, 359);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(116, 23);
            this.BtnDeleteEmployee.TabIndex = 25;
            this.BtnDeleteEmployee.Text = "Delete Employee";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Location = new System.Drawing.Point(418, 415);
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(350, 23);
            this.sqlTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sqlTextBox);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnUpdateEmployee);
            this.Controls.Add(this.BtnInsertEmployee);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView EmployeeDataGridView;
        private Button BtnAddEmployee;
        private TextBox txtBoxSalary;
        private TextBox txtBoxName;
        private ComboBox comboBoxFaculty;
        private Label label1;
        private Panel panel1;
        private Button btnStudent;
        private Button btnExam;
        private Button btnHome;
        private Button btnFaculty;
        private Button btnEmployee;
        private Button btnCourse;
        private TextBox TxtBoxId;
        private Button BtnInsertEmployee;
        private Button BtnUpdateEmployee;
        private Button BtnDeleteEmployee;
        private TextBox sqlTextBox;
        private Label label2;
    }
}