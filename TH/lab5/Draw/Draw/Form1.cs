using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, h, w; 

        Pen p = new Pen(Color.Black, 2);
        double shapeArea = 0;      
        const double Pi = 3.1416;

       

        private void color()
        {
            if(blue.Checked)
            {
                p.Color = Color.Blue;
            }   
             else if(red.Checked)
            {
                p.Color = Color.Red;
            }
            else if (yellow.Checked)
            {
                p.Color = Color.Yellow;
            }
             
        }
        private void IsMouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x; 
            w = e.Y - y;
            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
       
            if (radioCircle.Checked)
            {
                //  p.Color = Color.Blue;
                color();
                g.DrawEllipse(p, shape);
                shapeArea = h * w * Pi / 4;
                area.Text = ""+shapeArea;
            }
            else if (radioRectangle.Checked)
            {
                //  p.Color = Color.Red;
                color();
                g.DrawRectangle(p, shape);
                shapeArea = h * w ;
                area.Text = "" + shapeArea;
            }

        }
        private void IsMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
      
    }
}
