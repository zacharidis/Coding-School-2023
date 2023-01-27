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

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            int progress = (int) groupBox2.Width;
            int movements = (int) (progress / pbStew.Width);
            

            pbStew.Left += movements;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Kitchen emulator that uses ASYNC / AWAIT ", "By Georgios Zacharidis", MessageBoxButtons.OK);
        }
    }
}