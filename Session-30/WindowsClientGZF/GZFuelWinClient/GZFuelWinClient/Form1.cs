using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZFuelWinClient
{
    public partial class Form1 : Form
    {
        public const string BaseUrl = "https://localhost:7068/";
        public const string username = "admin";
        public const string password = "admin";
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            btnCustomers.Enabled = false;
            btnInventory.Enabled = false;
            btnTransactions.Enabled = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            var responce = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (responce == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void lblUnlock_Click(object sender, EventArgs e)
        {

            string input = string.Empty;
            if (ShowInputDialog(ref input) == DialogResult.OK)
            {
                if (input == "admin")
                {
                    btnCustomers.Enabled = true;
                    btnInventory.Enabled = true;
                    btnTransactions.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }


        }

        // doing that in VB was way easier !!! InputBox for the win !
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Password";
            

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.PasswordChar = '*';
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            frmTransactions.ShowDialog();


        }

        private void lblAbout_Click(object sender, EventArgs e)
        {

            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }
    }
}



// THE END ! Last Commit and the time is 11:30 PM 27/02/2023 !
// Thank you EpsilonNET for the ride 
// May the force of .NET and the mighty Entity Framework be with us all !