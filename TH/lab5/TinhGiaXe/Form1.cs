using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhGiaXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  void Tinhtien  ()

        {
            bool input;
            double distance;
            double sotien = 0;
            input = double.TryParse(txtQd.Text, out distance);
            if (input )
            {
                if(Xe7cho.Checked)  // XE 7 CHO 
                {
                    if (distance <= 1)
                        sotien =
                            17000;
                    else if (distance <= 5)
                        sotien = 17000 + 4 * 15000 + (distance - 5) * 12000;
                    else if (distance <= 100)
                        sotien = 17000 + 4 * 15000 + 95 * 12000 + (distance - 100) * 11000;

                }
                if (xe4cho.Checked)   // tinh xe 47 cho 

                {
                    if (distance <= 1)
                        sotien = 15000;
                    else if (distance <= 5)
                        sotien = 15000 + 4 * 13500 + (distance - 5) * 12000;
                    else if (sotien <= 100)
                        sotien = 15000 + 4 * 13500 + 95 * 11000 + (distance - 100) * 10000; 

                }

                if (checkGiamgia.Checked) sotien *= 0.95 ;
                txtKQ.Text = sotien.ToString();
            }
            else
            {
                txtKQ.ForeColor = Color.Red;
                txtKQ.Text = "loi dang nhap";
            }
                 


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtQd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Quangduong = Double.Parse(txtKQ.Text);
                if (Quangduong < 0)
                { 
                     txtKQ.Text = "Quang duong phai > 0!";
                }
                else
                {
                    txtKQ.ForeColor = Color.Black;
                    Tinhtien(); 
                }
            }
          catch
            {
                txtKQ.ForeColor = Color.Black;
                txtKQ.Text = " ERROR!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkGiamgia_CheckedChanged(object sender, EventArgs e)
        {
            Tinhtien();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {
            Tinhtien();
        }
    }
}
