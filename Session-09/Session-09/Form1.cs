using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace Session_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Super Calc " , "By Georgios Zacharidis" ,MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text= ctrlTxtExpression.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text=ctrlTxtExpression.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "9";


        }

        private void button12_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + "0";
        }
    }
}