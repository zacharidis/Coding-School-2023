namespace GZFuelWinClient
{
    partial class frmTransactions
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
            grbTransactions = new GroupBox();
            dgvTransactions = new DataGridView();
            grbAddNewTransaction = new GroupBox();
            grbTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // grbTransactions
            // 
            grbTransactions.Controls.Add(dgvTransactions);
            grbTransactions.Location = new Point(15, 14);
            grbTransactions.Name = "grbTransactions";
            grbTransactions.Size = new Size(903, 310);
            grbTransactions.TabIndex = 0;
            grbTransactions.TabStop = false;
            grbTransactions.Text = "Transactions";
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(20, 26);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowTemplate.Height = 25;
            dgvTransactions.Size = new Size(859, 264);
            dgvTransactions.TabIndex = 0;
            // 
            // grbAddNewTransaction
            // 
            grbAddNewTransaction.Location = new Point(22, 337);
            grbAddNewTransaction.Name = "grbAddNewTransaction";
            grbAddNewTransaction.Size = new Size(896, 231);
            grbAddNewTransaction.TabIndex = 1;
            grbAddNewTransaction.TabStop = false;
            grbAddNewTransaction.Text = "Add New Transaction";
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 580);
            Controls.Add(grbAddNewTransaction);
            Controls.Add(grbTransactions);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmTransactions";
            Text = "Transactions";
            grbTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTransactions;
        private DataGridView dgvTransactions;
        private GroupBox grbAddNewTransaction;
    }
}