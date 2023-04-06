namespace QuaySo
{
    public partial class Form1 : Form
    {
        Random Rand = new Random();
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int so1 = Rand.Next(10);
            int so2 = Rand.Next(10);
            int so3 = Rand.Next(10);

            lb1.Text = so1.ToString();
            lb2.Text = so2.ToString();
            lb3.Text = so3.ToString();

            if (so1 == so2 && so2 == so3)
                sum += 100;
            sum -= 10;

            lbKetqua.Text = sum.ToString();

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}