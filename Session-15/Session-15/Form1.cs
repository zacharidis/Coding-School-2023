namespace Session_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkStew_CheckedChanged(object sender, EventArgs e)
        {
            pbStew.Image = Resource1.stew;
        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            pbFries.Image = Resource1.fries;
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            pbSalad.Image = Resource1.Salad;
        }

        private void chkPepsi_CheckedChanged(object sender, EventArgs e)
        {
            pbPepsi.Image = Resource1.pepsi;
        }
    }
}