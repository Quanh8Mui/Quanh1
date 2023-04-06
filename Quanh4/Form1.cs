using System.Security.Cryptography.Xml;

namespace Quanh4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dx = 5;
        int dy = 7;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBall.Left <= 0 || picBall.Right >= ClientRectangle.Width)
                dx = -dx;
            if (picBall.Top <= 0 || picBall.Bottom >= ClientRectangle.Height)
                dy = -dy;

            picBall.Left += dx;
            picBall.Top += dy;
        }
    }
}