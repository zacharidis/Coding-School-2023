namespace Session_11
{
    partial class LedgerForm
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
            grbLedger = new GroupBox();
            lstbLedger = new ListBox();
            btnLoadLedger = new Button();
            btnSaveLedger = new Button();
            grbLedger.SuspendLayout();
            SuspendLayout();
            // 
            // grbLedger
            // 
            grbLedger.Controls.Add(lstbLedger);
            grbLedger.Location = new Point(12, 12);
            grbLedger.Name = "grbLedger";
            grbLedger.Size = new Size(624, 475);
            grbLedger.TabIndex = 2;
            grbLedger.TabStop = false;
            grbLedger.Text = "Current Ledger";
            // 
            // lstbLedger
            // 
            lstbLedger.BorderStyle = BorderStyle.None;
            lstbLedger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstbLedger.FormattingEnabled = true;
            lstbLedger.ItemHeight = 21;
            lstbLedger.Location = new Point(14, 23);
            lstbLedger.Name = "lstbLedger";
            lstbLedger.Size = new Size(604, 420);
            lstbLedger.TabIndex = 0;
            // 
            // btnLoadLedger
            // 
            btnLoadLedger.Location = new Point(12, 511);
            btnLoadLedger.Name = "btnLoadLedger";
            btnLoadLedger.Size = new Size(148, 30);
            btnLoadLedger.TabIndex = 3;
            btnLoadLedger.Text = "Load Current Ledger";
            btnLoadLedger.UseVisualStyleBackColor = true;
            btnLoadLedger.Click += btnLoadLedger_Click;
            // 
            // btnSaveLedger
            // 
            btnSaveLedger.Location = new Point(488, 511);
            btnSaveLedger.Name = "btnSaveLedger";
            btnSaveLedger.Size = new Size(148, 30);
            btnSaveLedger.TabIndex = 4;
            btnSaveLedger.Text = "Save Ledger to File";
            btnSaveLedger.UseVisualStyleBackColor = true;
            btnSaveLedger.Click += btnSaveLedger_Click;
            // 
            // LedgerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(648, 553);
            Controls.Add(btnSaveLedger);
            Controls.Add(btnLoadLedger);
            Controls.Add(grbLedger);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LedgerForm";
            Text = "LedgerForm";
            Load += LedgerForm_Load;
            grbLedger.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLedger;
        private ListBox lstbLedger;
        private Button btnLoadLedger;
        private Button btnSaveLedger;
    }
}