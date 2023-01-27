using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class LedgerForm : Form



    {

        MonthlyLedger MonthlyLedger { get; set; } = new();
        public LedgerForm(MonthlyLedger data)
        {
            MonthlyLedger = data;
            InitializeComponent();
        }

        private void LedgerForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLoadLedger_Click(object sender, EventArgs e)
        {

            // Ledger has to be updated before listing the values on the lstbox. 
            //  WIP , each time the ledger object has to be updated - within any form - 
            // yes to be implemented


            lstbLedger.Items.Add($"Year:{MonthlyLedger.Year} Month:{MonthlyLedger.Month} [Income : {MonthlyLedger.Income}] ," +
                $" [Expenses : {MonthlyLedger.Expenses}] , [Total : {MonthlyLedger.Total}]");


        }

        private void btnSaveLedger_Click(object sender, EventArgs e)
        {
            LedgerFileHelper ledgerFileHelper = new LedgerFileHelper(MonthlyLedger);
            ledgerFileHelper.AppendToLedger(MonthlyLedger);
            MessageBox.Show("Ledger file updated !");
        }
    }
}
