using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen penr = new System.Drawing.Pen(Color.Red, 2);
 
        double n;
        double r;
        double c;
 
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
 
            Double.TryParse(textBox1.Text, out n);
            Double.TryParse(textBox2.Text, out r);
 
            double alpha1 = 0;
            double alpha2 = 2 * Math.PI / n;
 
            for (int i = 0; i <= n; i++)
            {
                double x1 = r * Math.Cos(alpha1);
                double y1 = r * Math.Sin(alpha1);
                double x2 = r * Math.Cos(alpha1 + alpha2);
                double y2 = r * Math.Sin(alpha1 + alpha2);
 
                float h = (float)0.5 * pictureBox1.Height;
                float w = (float)0.5 * pictureBox1.Width;
                alpha1 += alpha2;
 
                g.DrawLine(penr, (float)x1 + w, (float)y1 + h, (float)x2 + w, (float)y2 + h);
 
            }
          }
 
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
 
            Double.TryParse(textBox1.Text, out n);
            Double.TryParse(textBox2.Text, out r);
 
            double alpha1 = 0;
            double alpha2 = 360 / n;
 
            for (int i = 0; i <= n; i++)
            {
                double x1 = r * Math.Cos(alpha1);
                double y1 = r * Math.Sin(alpha1);
                double x2 = r * Math.Cos(alpha1 + alpha2);
                double y2 = r * Math.Sin(alpha1 + alpha2);
 
                float h = (float)0.5 * pictureBox1.Height;
                float w = (float)0.5 * pictureBox1.Width;
                alpha1 += alpha2;
 
                g.DrawLine(penr, (float)x1 + w, (float)y1 + h, (float)x2 + w, (float)y2 + h);
 
            }
        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
 
            Double.TryParse(textBox1.Text, out n);
            r = 0;
 
            double alpha1 = 0;
            double alpha2 = 2 * Math.PI / n;
 
            for (int i = 0; i <= 10 * n; i++)
            {
                double x1 = r * Math.Cos(alpha1);
                double y1 = r * Math.Sin(alpha1);
                double x2 = r * Math.Cos(alpha1 + alpha2);
                double y2 = r * Math.Sin(alpha1 + alpha2);
                
                float h = (float)0.5 * pictureBox1.Height;
                float w = (float)0.5 * pictureBox1.Width;
                alpha1 += alpha2;
                r += 0.2;
 
                g.DrawLine(penr, (float)x1 + w, (float)y1 + h, (float)x2 + w, (float)y2 + h);
 
            }
        }
 
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
 
            Double.TryParse(textBox1.Text, out n);
            Double.TryParse(textBox2.Text, out r);
            Double.TryParse(textBox3.Text, out c);
 
            double alpha1 = 0;
            double alpha2 = 2 * Math.PI / n;
 
            for (int j = 0; j < 3; j++)
            {
 
                for (int i = 0; i <= n; i++)
                {
                    double x1 = r * Math.Cos(alpha1);
                    double y1 = c * Math.Sin(alpha1);
                    double x2 = r * Math.Cos(alpha1 + alpha2);
                    double y2 = c * Math.Sin(alpha1 + alpha2);
 
                    float h = (float)0.5 * pictureBox1.Height;
                    float w = (float)0.5 * pictureBox1.Width;
                    alpha1 += alpha2;
 
                    g.DrawLine(penr, (float)x1 + w, (float)y1 + h, (float)x2 + w, (float)y2 + h);
 
                }
 
                for (int i = 0; i <= n; i++)
                {
                    double x1 = c * Math.Cos(alpha1);
                    double y1 = r * Math.Sin(alpha1);
                    double x2 = c * Math.Cos(alpha1 + alpha2);
                    double y2 = r * Math.Sin(alpha1 + alpha2);
 
                    float h = (float)0.5 * pictureBox1.Height;
                    float w = (float)0.5 * pictureBox1.Width;
                    alpha1 += alpha2;
 
                    g.DrawLine(penr, (float)x1 + w, (float)y1 + h, (float)x2 + w, (float)y2 + h);
 
                }
                r = c;
                c += (c/2);
            }
            
        }
 
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
 
            Double.TryParse(textBox1.Text, out n);
            Double.TryParse(textBox2.Text, out r);
 
            double alpha1 = 0;
            double alpha2 = 2 * Math.PI / n;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i <= n; i++)
                {
                    double x1 = r * Math.Cos(alpha1);
                    double y1 = r * Math.Sin(alpha1);
                    double x2 = r * Math.Cos(alpha1 + alpha2);
                    double y2 = r * Math.Sin(alpha1 + alpha2);
 
                    float h = (float)0.5 * pictureBox1.Height;
                    float w = (float)0.5 * pictureBox1.Width;
                    alpha1 += alpha2;
 
                    g.DrawLine(penr, (float)x1 + w, (float)y1 + h, (float)x2 + w, (float)y2 + h);
 
                }
                r -= 20;
            }
        }
 
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
 
            double ax = 100;
            double ay = 100;
            double bx = 300;
            double by = 100;
            double cx = 300;
            double cy = 300;
            double dx = 100;
            double dy = 300;
 
            double mi = 0.2;
 
            for (int i = 0; i < Convert.ToDouble(textBox3.Text); i++)
            {
                g.DrawLine(penr, (float)ax, (float)ay, (float)bx, (float)by);
                g.DrawLine(penr, (float)bx, (float)by, (float)cx, (float)cy);
                g.DrawLine(penr, (float)cx, (float)cy, (float)dx, (float)dy);
                g.DrawLine(penr, (float)dx, (float)dy, (float)ax, (float)ay);
 
                ax = (1 - mi) * ax + mi * bx;
                ay = (1 - mi) * ay + mi * by;
 
                bx = (1 - mi) * bx + mi * cx;
                by = (1 - mi) * by + mi * cy;
 
                cx = (1 - mi) * cx + mi * dx;
                cy = (1 - mi) * cy + mi * dy;
 
                dx = (1 - mi) * dx + mi * ax;
                dy = (1 - mi) * dy + mi * ay;
            }
        }
    }
    }