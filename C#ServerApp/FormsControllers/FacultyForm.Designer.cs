namespace FormsControllers
{
    partial class FacultyForm
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
            this.FacultyDataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.BtnAddFaculty = new System.Windows.Forms.Button();
            this.BtnUpdateFaculty = new System.Windows.Forms.Button();
            this.BtnDeleteFaculty = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyDataGridView)).BeginInit();
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
            this.panel1.TabIndex = 11;
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
            // FacultyDataGridView
            // 
            this.FacultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacultyDataGridView.Location = new System.Drawing.Point(378, 0);
            this.FacultyDataGridView.Name = "FacultyDataGridView";
            this.FacultyDataGridView.RowTemplate.Height = 25;
            this.FacultyDataGridView.Size = new System.Drawing.Size(419, 229);
            this.FacultyDataGridView.TabIndex = 12;
            this.FacultyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacultyDataGridView_CellClick);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(215, 309);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Name";
            this.txtBoxName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxName.TabIndex = 13;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(215, 345);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.PlaceholderText = "Address";
            this.txtBoxAddress.Size = new System.Drawing.Size(100, 23);
            this.txtBoxAddress.TabIndex = 14;
            // 
            // txtBoxId
            // 
            this.txtBoxId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Location = new System.Drawing.Point(697, 235);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.PlaceholderText = "ID";
            this.txtBoxId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxId.TabIndex = 15;
            // 
            // BtnAddFaculty
            // 
            this.BtnAddFaculty.Location = new System.Drawing.Point(348, 309);
            this.BtnAddFaculty.Name = "BtnAddFaculty";
            this.BtnAddFaculty.Size = new System.Drawing.Size(75, 23);
            this.BtnAddFaculty.TabIndex = 16;
            this.BtnAddFaculty.Text = "Add";
            this.BtnAddFaculty.UseVisualStyleBackColor = true;
            this.BtnAddFaculty.Click += new System.EventHandler(this.BtnAddFaculty_Click);
            // 
            // BtnUpdateFaculty
            // 
            this.BtnUpdateFaculty.Location = new System.Drawing.Point(348, 345);
            this.BtnUpdateFaculty.Name = "BtnUpdateFaculty";
            this.BtnUpdateFaculty.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateFaculty.TabIndex = 17;
            this.BtnUpdateFaculty.Text = "Update";
            this.BtnUpdateFaculty.UseVisualStyleBackColor = true;
            this.BtnUpdateFaculty.Click += new System.EventHandler(this.BtnUpdateFaculty_Click);
            // 
            // BtnDeleteFaculty
            // 
            this.BtnDeleteFaculty.Location = new System.Drawing.Point(348, 388);
            this.BtnDeleteFaculty.Name = "BtnDeleteFaculty";
            this.BtnDeleteFaculty.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteFaculty.TabIndex = 18;
            this.BtnDeleteFaculty.Text = "Delete";
            this.BtnDeleteFaculty.UseVisualStyleBackColor = true;
            this.BtnDeleteFaculty.Click += new System.EventHandler(this.BtnDeleteFaculty_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteFaculty);
            this.Controls.Add(this.BtnUpdateFaculty);
            this.Controls.Add(this.BtnAddFaculty);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.FacultyDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacultyDataGridView)).EndInit();
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
        public DataGridView FacultyDataGridView;
        private TextBox txtBoxName;
        private TextBox txtBoxAddress;
        private TextBox txtBoxId;
        private Button BtnAddFaculty;
        private Button BtnUpdateFaculty;
        private Button BtnDeleteFaculty;
    }
}