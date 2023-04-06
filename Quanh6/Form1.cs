namespace Quanh6
{
    public partial class Form1 : Form
    {
        public static string Tendangnhap="";
        public Form1()
        {
            Form2 f = new Form2();
            f.ShowDialog();
            InitializeComponent();
        }
    }
}