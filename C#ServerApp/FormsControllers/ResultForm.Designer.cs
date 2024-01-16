namespace FormsControllers
{
    partial class ResultForm
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
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.DeleteResultButton = new System.Windows.Forms.Button();
            this.addResultButton = new System.Windows.Forms.Button();
            this.updateResultButton = new System.Windows.Forms.Button();
            this.txtBoxStudentID = new System.Windows.Forms.TextBox();
            this.txtBoxExamId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
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
            this.panel1.TabIndex = 14;
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
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(285, 12);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowTemplate.Height = 25;
            this.resultDataGridView.Size = new System.Drawing.Size(503, 309);
            this.resultDataGridView.TabIndex = 17;
            this.resultDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataGridView_CellClick);
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.Location = new System.Drawing.Point(285, 336);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.PlaceholderText = "Points";
            this.txtBoxPoints.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPoints.TabIndex = 33;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(285, 365);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(100, 23);
            this.comboBoxStudent.TabIndex = 32;
            this.comboBoxStudent.Text = "Student";
            // 
            // DeleteResultButton
            // 
            this.DeleteResultButton.Location = new System.Drawing.Point(391, 394);
            this.DeleteResultButton.Name = "DeleteResultButton";
            this.DeleteResultButton.Size = new System.Drawing.Size(94, 23);
            this.DeleteResultButton.TabIndex = 31;
            this.DeleteResultButton.Text = "Delete Result ";
            this.DeleteResultButton.UseVisualStyleBackColor = true;
            this.DeleteResultButton.Click += new System.EventHandler(this.DeleteResultButton_Click);
            // 
            // addResultButton
            // 
            this.addResultButton.Location = new System.Drawing.Point(391, 336);
            this.addResultButton.Name = "addResultButton";
            this.addResultButton.Size = new System.Drawing.Size(94, 23);
            this.addResultButton.TabIndex = 30;
            this.addResultButton.Text = "Add Result";
            this.addResultButton.UseVisualStyleBackColor = true;
            this.addResultButton.Click += new System.EventHandler(this.AddResultButton_Click);
            // 
            // updateResultButton
            // 
            this.updateResultButton.Location = new System.Drawing.Point(391, 365);
            this.updateResultButton.Name = "updateResultButton";
            this.updateResultButton.Size = new System.Drawing.Size(94, 23);
            this.updateResultButton.TabIndex = 29;
            this.updateResultButton.Text = "Update Result";
            this.updateResultButton.UseVisualStyleBackColor = true;
            this.updateResultButton.Click += new System.EventHandler(this.UpdateResult_Click);
            // 
            // txtBoxStudentID
            // 
            this.txtBoxStudentID.Enabled = false;
            this.txtBoxStudentID.HideSelection = false;
            this.txtBoxStudentID.Location = new System.Drawing.Point(688, 336);
            this.txtBoxStudentID.Name = "txtBoxStudentID";
            this.txtBoxStudentID.PlaceholderText = "StudentId";
            this.txtBoxStudentID.ReadOnly = true;
            this.txtBoxStudentID.Size = new System.Drawing.Size(100, 23);
            this.txtBoxStudentID.TabIndex = 34;
            // 
            // txtBoxExamId
            // 
            this.txtBoxExamId.Enabled = false;
            this.txtBoxExamId.Location = new System.Drawing.Point(582, 336);
            this.txtBoxExamId.Name = "txtBoxExamId";
            this.txtBoxExamId.ReadOnly = true;
            this.txtBoxExamId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxExamId.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxExamId);
            this.Controls.Add(this.txtBoxStudentID);
            this.Controls.Add(this.txtBoxPoints);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.DeleteResultButton);
            this.Controls.Add(this.addResultButton);
            this.Controls.Add(this.updateResultButton);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
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
        private DataGridView resultDataGridView;
        private TextBox txtBoxPoints;
        private ComboBox comboBoxStudent;
        private Button DeleteResultButton;
        private Button addResultButton;
        private Button updateResultButton;
        private TextBox txtBoxStudentID;
        private TextBox txtBoxExamId;
        private Label label1;
    }
}