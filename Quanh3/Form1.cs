namespace Quanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            Phanso p1 = new Phanso(int.Parse(txtTuso1.Text),
                int.Parse(txtMauso1.Text));
            Phanso p2 = new Phanso(int.Parse(txtTuso2.Text),
           int.Parse(txtMauso2.Text));

            Phanso kq = p1.Cong(p2);

            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            Phanso p1 = new Phanso(int.Parse(txtTuso1.Text),
               int.Parse(txtMauso1.Text));
            Phanso p2 = new Phanso(int.Parse(txtTuso2.Text),
           int.Parse(txtMauso2.Text));

            Phanso kq = p1.Tru(p2);

            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            Phanso p1 = new Phanso(int.Parse(txtTuso1.Text),
               int.Parse(txtMauso1.Text));
            Phanso p2 = new Phanso(int.Parse(txtTuso2.Text),
           int.Parse(txtMauso2.Text));

            Phanso kq = p1.Nhan(p2);

            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            Phanso p1 = new Phanso(int.Parse(txtTuso1.Text),
               int.Parse(txtMauso1.Text));
            Phanso p2 = new Phanso(int.Parse(txtTuso2.Text),
           int.Parse(txtMauso2.Text));

            Phanso kq = p1.Chia(p2);

            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }
    }
}