using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanh6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if (txtDangnhap.Text == "" || txtMatkhau.Text != "admin")
                Application.Exit();
            else
            {
                Form1.Tendangnhap = txtDangnhap.Text;
                this.Close();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Form1.Tendangnhap == "")
                Application.Exit();
        }
    }
}
