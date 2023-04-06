using System.Linq.Expressions;

namespace GiupBeHocToan
{
    public partial class Form1 : Form
    {
        Random Rand = new Random();
        String[] Pheptoan = { "+", "-", "x", ":" };
        int vitri;
        public Form1()
        {
            InitializeComponent();
            taoPhepToan();
        }

        private void taoPhepToan()
        {
            int so1 = Rand.Next(10);
            int so2 = Rand.Next(1, 10);
            vitri = Rand.Next(4);

            lbSo.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbPheptinh.Text = Pheptoan[vitri];
        }

        private void btKetqua_Click(object sender, EventArgs e)
        {
            taoPhepToan();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(lbSo.Text);
                int b = int.Parse(lbSo2.Text);

                int sochon = int.Parse(txtDapan.Text);
                int dapan = 0;


                switch (vitri)
                {
                    case 0:
                        dapan = a + b;
                        break;
                    case 1:
                        dapan = a - b;
                        break;
                    case 2:
                        dapan = a * b;
                        break;
                    case 3:
                        dapan = a / b;
                        break;
                }
                if (sochon == dapan)
                {
                    lbKetqua.Text = "Dung roi!";
                }
                else
                    lbKetqua.Text = "Sai. Ket qua la: " + dapan.ToString();
            }
            catch { }
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (txtDapan.Text != "") return;
            txtDapan.Text = "-";
        }

        private void btSo0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDapan.Text += bt.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtDapan.Text == "") return;
            txtDapan.Text = txtDapan.Text.Substring(0, txtDapan.Text.Length-1);
        }
    }
}