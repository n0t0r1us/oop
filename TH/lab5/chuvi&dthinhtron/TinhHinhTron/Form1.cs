using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhHinhTron
{
    public partial class Form1 : Form
    {
        public static double PI = 3.1416;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double r = double.Parse(BanKinh.Text);
            // tính chu vi & gửi giá trị cho lable kết quả
            if (r > 0)
            {
                double chuvi = PI*(r * 2);
               lblKetqua.Text = "chu vi = " + chuvi.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double r = double.Parse(BanKinh.Text);
            // tính chu vi & gửi giá trị cho lable kết quả
            if (r > 0)
            {
                double dientich = PI * (r * r);
                lblKetqua.Text = "Dien tich = " + dientich.ToString();
            }

        }

        private void BanKinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(BanKinh.Text);
            }
            catch
            {
                MessageBox.Show("cần nhập gái trị số");
            }
        }
    }
}
