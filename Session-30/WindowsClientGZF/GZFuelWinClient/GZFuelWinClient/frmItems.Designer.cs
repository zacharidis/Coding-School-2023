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
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(17, 23);
            dgvItems.Name = "dgvItems";
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(698, 307);
            dgvItems.TabIndex = 0;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 495);
            Controls.Add(dgvItems);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmItems";
            Text = "frmItems";
            Load += frmItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
    }
}