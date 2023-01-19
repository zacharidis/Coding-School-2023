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
    }
}