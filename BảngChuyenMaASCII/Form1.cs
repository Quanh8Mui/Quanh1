using System.Text;

namespace BảngChuyenMaASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btChuyen1_Click(object sender, EventArgs e)
        {
            string x = txtMa.Text;
            byte[] xBytes = x.Split(' ').Select(b => byte.Parse(b)).ToArray();
            string bCharacter = Encoding.ASCII.GetString(xBytes);

            lbKetqua1.Text = bCharacter;
        }

        private void btChuyen2_Click(object sender, EventArgs e)
        {
            string a = txtKytu.Text;
            byte[] aBytes = Encoding.ASCII.GetBytes(a);
            string aValue = string.Join(" ", aBytes);

            lbKetqua2.Text = aValue;
        }

    }
}