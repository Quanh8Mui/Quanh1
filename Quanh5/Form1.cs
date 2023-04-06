namespace Quanh5
{
    public partial class Form1 : Form
    {
        string pathImg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbName.Text = "     12345 - Trần Quang Anh     ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0,1);
        }
    }
}