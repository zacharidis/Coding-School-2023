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


        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPepsi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            int progress = (int)groupBox2.Width;
            int movements = (int)(progress / pbStew.Width);

            FillImages();



        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Kitchen emulator that uses ASYNC / AWAIT ", "By Georgios Zacharidis", MessageBoxButtons.OK);
        }


        private void FillImages()
        {

            int counter = 0;
            if (chkFries.Checked)
            {
                pbFries.Image = Resource1.fries;
                counter++;
            }
            else { pbFries.Image = null; }

            if (chkPepsi.Checked)
            {
                pbPepsi.Image = Resource1.pepsi;
                counter++;
            }
            else { pbPepsi.Image = null; }

            if (chkSalad.Checked)
            {
                pbSalad.Image = Resource1.Salad;
                counter++;

            }
            else { pbSalad.Image = null; }

            if (chkStew.Checked)
            {
                pbStew.Image = Resource1.stew;
                counter++;

            }
            else { pbStew.Image = null; }

            if (counter == 0)
            {
                MessageBox.Show("Nothing to eat !", "Empty Order", MessageBoxButtons.OK);
            }


        }
    }
}