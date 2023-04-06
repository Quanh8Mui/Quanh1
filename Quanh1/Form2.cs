using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanh1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txtSo1.Text));
                int b = checked(int.Parse(txtSo2.Text));
                if (btCong.Checked)
                    lbKetqua.Text = String.Format("{0}", checked(a + b));
                else if (btTru.Checked)
                    lbKetqua.Text = String.Format("{0}", checked(a - b));
                else if (btNhan.Checked)
                    lbKetqua.Text = String.Format("{0}", checked(a * b));
                else if (btChia.Checked)
                {
                    if (b == 0)
                        throw new DivideByZeroException("Phai nhap so khac 0");
                    lbKetqua.Text = String.Format("{0}", checked(a / b));
                }
                else
                    lbKetqua.Text = String.Format("{0}", a % b);
            }
            catch (FormatException)
            {
                lbKetqua.Text = "Ban nhap vao so tu nhien";
            }
            catch (DivideByZeroException ex)
            {
                lbKetqua.Text = ex.Message;
            }
            catch (OverflowException)
            {
                lbKetqua.Text = "Khong the xu li so qua lon";
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
