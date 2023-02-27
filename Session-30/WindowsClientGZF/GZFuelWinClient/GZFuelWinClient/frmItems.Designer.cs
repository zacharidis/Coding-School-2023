namespace GZFuelWinClient
{
    partial class frmItems
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
            dgvItems = new DataGridView();
            groupBox1 = new GroupBox();
            gbxItemDetails = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            gbxItemDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(16, 22);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(617, 307);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbxItemDetails);
            groupBox1.Controls.Add(dgvItems);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1059, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory";
            // 
            // gbxItemDetails
            // 
            gbxItemDetails.Controls.Add(label6);
            gbxItemDetails.Controls.Add(label5);
            gbxItemDetails.Controls.Add(label4);
            gbxItemDetails.Controls.Add(label3);
            gbxItemDetails.Controls.Add(label2);
            gbxItemDetails.Controls.Add(label1);
            gbxItemDetails.Location = new Point(657, 15);
            gbxItemDetails.Name = "gbxItemDetails";
            gbxItemDetails.Size = new Size(396, 314);
            gbxItemDetails.TabIndex = 1;
            gbxItemDetails.TabStop = false;
            gbxItemDetails.Text = "Item Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Item ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Item Code : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 156);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 200);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 243);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 587);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmItems";
            Text = "frmItems";
            Load += frmItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            gbxItemDetails.ResumeLayout(false);
            gbxItemDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
        private GroupBox groupBox1;
        private GroupBox gbxItemDetails;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}