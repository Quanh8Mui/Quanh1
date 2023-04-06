using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GiaiPhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbKetqua.Text = "";
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                int b = int.Parse(txt2.Text);
                int c = int.Parse(txt3.Text);
                double delta;

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            lbKetqua.Text = "Phuong trinh co vo so nghiem";
                        else
                            lbKetqua.Text = "Phuong trinh vo nghiem";
                    }
                    else
                        lbKetqua.Text = "Phuong trinh co nghiem:x= " + (double)-c / b;
                }
                else
                {
                    delta = Math.Pow(b, 2) - 4 * a * c;
                    if (delta < 0)
                        lbKetqua.Text = "Phuong tirnh vo nghiem";
                    else if (delta == 0)
                        lbKetqua.Text = "Phuong trinh co 2 nghiem trung nhau: -b/2a = " + (double)-b / 2 * a;
                    else if (delta > 0)
                        lbKetqua.Text = "Phuong trinh co 2 nghiem phan biet: x1= " + (double)(-b + Math.Sqrt(delta)) / 2 * a
                            + " x2= " + (double)(-b - Math.Sqrt(delta)) / 2 * a;
                }
            }
            catch (FormatException)
            {
                lbKetqua.Text = "Nhap vao cac gia tri la so nguyen";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}