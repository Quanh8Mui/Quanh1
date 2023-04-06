namespace Quanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Rand = new Random();
        int Diem = 0;
        private void btQuayso_Click(object sender, EventArgs e)
        {
            int so1 = Rand.Next(1, 7);
            int so2 = Rand.Next(1, 7);
            int so3 = Rand.Next(1, 7);

            lbs1.Text = so1.ToString();
            lbs2.Text = so2.ToString();
            lbs3.Text = so3.ToString();

            if (rd3.Checked)
            {
                if (so1 + so2 + so3 <= 10)
                    Diem += 10;
                else
                Diem -= 10;
            }
            else
            {
                if (so1 + so2 + so3 >= 11)
                    Diem += 10;
                else
                Diem -= 10;
            }
            lbKetqua.Text = Diem.ToString();
              
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}