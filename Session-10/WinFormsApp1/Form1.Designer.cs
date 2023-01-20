namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStudents = new System.Windows.Forms.Label();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.lblCourses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvSchedule = new System.Windows.Forms.DataGridView();
            this.lblSchedules = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(821, 43);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(359, 47);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(821, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(359, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "DataGridView and Seriliazer Exercise made for E Coding School.  By Georgios Zacha" +
    "ridis";
            // 
            // grvStudents
            // 
            this.grvStudents.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Location = new System.Drawing.Point(81, 43);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(711, 140);
            this.grvStudents.TabIndex = 9;
            this.grvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvStudents_CellContentClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Session_06.Stuff.Student);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(12, 85);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(68, 15);
            this.lblStudents.TabIndex = 10;
            this.lblStudents.Text = "STUDENTS :";
            // 
            // grvCourses
            // 
            this.grvCourses.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Location = new System.Drawing.Point(84, 216);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(708, 117);
            this.grvCourses.TabIndex = 11;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(24, 273);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(60, 15);
            this.lblCourses.TabIndex = 12;
            this.lblCourses.Text = "COURSES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "GRADES:";
            // 
            // grvGrades
            // 
            this.grvGrades.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Location = new System.Drawing.Point(81, 371);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(711, 117);
            this.grvGrades.TabIndex = 14;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.studentBindingSource;
            // 
            // grvSchedule
            // 
            this.grvSchedule.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.grvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedule.Location = new System.Drawing.Point(81, 528);
            this.grvSchedule.Name = "grvSchedule";
            this.grvSchedule.RowTemplate.Height = 25;
            this.grvSchedule.Size = new System.Drawing.Size(711, 117);
            this.grvSchedule.TabIndex = 15;
            // 
            // lblSchedules
            // 
            this.lblSchedules.AutoSize = true;
            this.lblSchedules.Location = new System.Drawing.Point(22, 528);
            this.lblSchedules.Name = "lblSchedules";
            this.lblSchedules.Size = new System.Drawing.Size(38, 15);
            this.lblSchedules.TabIndex = 16;
            this.lblSchedules.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1191, 732);
            this.ControlBox = false;
            this.Controls.Add(this.lblSchedules);
            this.Controls.Add(this.grvSchedule);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.grvStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PrintDialog printDialog1;
        private Button btnLoad;
        private Button btnSave;
        private Label label1;
        private DataGridView grvStudents;
        private Label lblStudents;
        private DataGridView grvCourses;
        private Label lblCourses;
        private Label label2;
        private DataGridView grvGrades;
        private BindingSource studentBindingSource;
        private BindingSource coursesBindingSource;
        private DataGridView grvSchedule;
        private Label lblSchedules;
    }
}