using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptBac2_FORM
{
    public partial class Form1 : Form
    {
        public double a = 0;
        public double b = 0;
        public double c = 0;
        double x1 = 0;
        double x2 = 0;
        double x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHesoa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            /*double a = double.Parse(txtHesoa.Text);
            double b = double.Parse(txtHesob.Text);
            double c = double.Parse(txtHesoc.Text);*/

            bool resulta = double.TryParse(txtHesoa.Text,out a);
            bool resultb = double.TryParse(txtHesob.Text,out b);
            bool resultc = double.TryParse(txtHesoc.Text,out c);
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        btnketqua.Text = "PTVSN";
                    else btnketqua.Text = " PTVN";
                else
                {
                    btnketqua.Text = "PT có nghiệm " + (-c / b);
                    double x;
                    x = -b / c;
                    btnketqua.Text = "x = " + x;
                }
            if(!(resulta && resultb && resultc))
            {
                btnketqua.Text = "không chứa kí tự";
            }
            else
            {

                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    btnketqua.Text = "phương trình vô nghiệm";

                }
                else if (delta == 0)
                {
                    x = x1 = x2 = -b / (2 * a);
                    btnketqua.Text = "phương trình có nghiệm kép x1 = x2 = " + x;
                }
                else if (delta > 0)
                {
                    delta = Math.Sqrt(delta);
                    x1 = (-b + delta) / (2 * a);
                    x2 = (-b - delta) / (2 * a);
                    btnketqua.Text = "phương trình có 2 nghiệm x1= " + x1  + "x2= " + x2;
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHesob_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHesoc_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
