namespace Caculator
{
    public partial class Form1 : Form
    {
        string dau;
        int temp;
        public Form1()
        {
            InitializeComponent();
            txtTinh.Text = "";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtTinh.Text += bt.Text;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtTinh.Text == "")
                return;
            txtTinh.Text = txtTinh.Text.Substring(0, txtTinh.Text.Length - 1);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtTinh.Text = "";
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int a = int.Parse(txtTinh.Text);
                int b = int.Parse(txtTinh.Text);

                if(dau == "+")
                {
                    temp = a + b;
                    txtTinh.Text = temp.ToString();
                }
            }
            catch { }
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            dau = "+";
            txtTinh.Text += dau;    
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dau = "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dau = "x";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dau = ":";
        }
    }
}