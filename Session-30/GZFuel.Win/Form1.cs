namespace GZFuel.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = 640;
            this.Height = 480;
            this.StartPosition = FormStartPosition.CenterScreen;


        }




        //-----------move the form without a border 

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Width == 1024) 
                    { 
                this.Width = 640;
                        this.Height = 480;

            }else
            {
                this.Width = 1024;
                this.Height = 768;
            }
            


            
            
        }
    }
}