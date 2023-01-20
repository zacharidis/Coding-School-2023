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
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
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
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(997, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(359, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Load Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(997, 605);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(359, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save Data";
            this.button3.UseVisualStyleBackColor = true;
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
            this.grvStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Location = new System.Drawing.Point(81, 43);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(1266, 140);
            this.grvStudents.TabIndex = 9;
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
            // grvGrades
            // 
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Location = new System.Drawing.Point(84, 216);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(1263, 117);
            this.grvGrades.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "GRADES:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1403, 732);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.grvStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PrintDialog printDialog1;
        private Button button2;
        private Button button3;
        private Label label1;
        private DataGridView grvStudents;
        private Label lblStudents;
        private DataGridView grvGrades;
        private Label label2;
    }
}