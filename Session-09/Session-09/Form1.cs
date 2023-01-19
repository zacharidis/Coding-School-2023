using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using CalculatorLib;

namespace Session_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // check if the last character is either - or + or / or * or ^ or  r
        public bool isValid(string lastInput)

        {
            if ((lastInput.EndsWith("/")) || 
                ((lastInput.EndsWith("+")) ||
                ((lastInput.EndsWith("-")) ||
                ((lastInput.EndsWith("^")) ||
                ((lastInput.EndsWith("r")))))))
           {
                return false;
            }
            return true;
            
            
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

        private void button13_Click(object sender, EventArgs e)
        {
            if (isValid(ctrlTxtExpression.Text)) {

                ctrlTxtExpression.Text = ctrlTxtExpression.Text + "+";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isValid(ctrlTxtExpression.Text))
            {

                ctrlTxtExpression.Text = ctrlTxtExpression.Text + "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isValid(ctrlTxtExpression.Text))
            {

                ctrlTxtExpression.Text = ctrlTxtExpression.Text + "*";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (isValid(ctrlTxtExpression.Text))
            {

                ctrlTxtExpression.Text = ctrlTxtExpression.Text + "/";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (isValid(ctrlTxtExpression.Text))
            {

                ctrlTxtExpression.Text = ctrlTxtExpression.Text + "^";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isValid(ctrlTxtExpression.Text))
            {

                CalculatorLib.Calculator root = new CalculatorLib.Calculator();
                ctrlTxtResults.Text = root.Root(double.Parse(ctrlTxtExpression.Text));
            }
        }

        private void button19_Click(object sender, EventArgs e)

        {
            CalculatorLib.Calculator class1= new CalculatorLib.Calculator();
            ctrlTxtResults.Text =  class1.Parser(ctrlTxtExpression.Text);
            ctrlTxtExpression.Text = string.Empty;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = string.Empty;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ctrlTxtExpression.Text = ctrlTxtExpression.Text + ".";
        }
    }
}