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

            InitTheBars();

            FillImages();
            PrepareMeal();
            



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

        private async Task PrepareMeal()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);

            });

            progressBar1.PerformStep();

        }

        private void InitTheBars()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 25;
        }
    }
}