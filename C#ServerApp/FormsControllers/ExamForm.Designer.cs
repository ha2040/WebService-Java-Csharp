namespace FormsControllers
{
    partial class ExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

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
            this.examDataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxRoomId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examDataGridView)).BeginInit();
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
            this.panel1.TabIndex = 15;
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
            // examDataGridView
            // 
            this.examDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examDataGridView.Location = new System.Drawing.Point(285, 12);
            this.examDataGridView.Name = "examDataGridView";
            this.examDataGridView.ReadOnly = true;
            this.examDataGridView.RowTemplate.Height = 25;
            this.examDataGridView.Size = new System.Drawing.Size(503, 309);
            this.examDataGridView.TabIndex = 16;
            this.examDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ExamDataGridView_CellBeginEdit);
            this.examDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamDataGridView_CellClick);
            this.examDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamDataGridView_CellEndEdit);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Location = new System.Drawing.Point(688, 329);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.PlaceholderText = "ID";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxId.TabIndex = 17;
            // 
            // txtBoxRoomId
            // 
            this.txtBoxRoomId.Location = new System.Drawing.Point(285, 386);
            this.txtBoxRoomId.Name = "txtBoxRoomId";
            this.txtBoxRoomId.PlaceholderText = "RoomID";
            this.txtBoxRoomId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxRoomId.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 415);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update Exam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnUpdateExam);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add Exam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnAddExam);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete Exam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnDeleteExam);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(285, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Course";
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(285, 330);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.PlaceholderText = "Credits";
            this.creditTextBox.Size = new System.Drawing.Size(100, 23);
            this.creditTextBox.TabIndex = 25;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(713, 415);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 26;
            this.resultButton.Text = "View Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxRoomId);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.examDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examDataGridView)).EndInit();
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
        private DataGridView examDataGridView;
        private TextBox txtBoxId;
        private TextBox txtBoxRoomId;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private TextBox creditTextBox;
        private Button resultButton;
        private Label label1;
    }
}