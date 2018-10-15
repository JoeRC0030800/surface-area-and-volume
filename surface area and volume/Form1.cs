using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surface_area_and_volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCl_Click(object sender, EventArgs e)
        {
            try
            {


                double R = Convert.ToDouble(TxtBxRadius.Text);

                double SurfaceArea = 4 * Math.PI * R * R;

                LblSurf.Text = "Surface Area = " + SurfaceArea.ToString("0.00");

                double Rd = Convert.ToDouble(TxtBxRadius.Text);

                double Volume = (4.0 / 3.0) * Math.PI * Rd * Rd * Rd;
                LblVol.Text = "Volume = " + Volume.ToString("0.00");
            }
            catch
            {

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(textBox1.Text);
                double H = Convert.ToDouble(textBox2.Text);

                double SurfaceAr = Math.PI * R * (R + Math.Sqrt(H * H + R * R));
                double Vol = Math.PI *( R * R) * (H / 3);

                label6.Text = "Surface Area =" + SurfaceAr.ToString("0.00");
                label7.Text = "Volume =" + Vol.ToString("0.00");
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(textBox3.Text);

                double SurfaceArea = 6 * (A * A);
                double Volume = (A * A * A);
                label10.Text = "Surface Area =" + SurfaceArea.ToString("0.00");
                label11.Text = "Volume =" + Volume.ToString("0.00");
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(textBox4.Text);
                double H = Convert.ToDouble(textBox5.Text);

                double SurfaceArea = (2 * Math.PI * R * H) + (2 * Math.PI * R * R);
                double Volume = Math.PI * (R * R) * H;

                label15.Text = "Surface Area =" + SurfaceArea.ToString("0.00");
                label16.Text = "Volume =" + Volume.ToString("0.00");
            }
            catch
            {

            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double L = Convert.ToDouble(textBox6.Text);
                double B = Convert.ToDouble(textBox7.Text);
                double H = Convert.ToDouble(textBox8.Text);

                double SurfaceArea = (L * H + L * H) + (H * B + H * B) + (L * B + L * B);
                double Volume = L * H * B;

                label21.Text = "Volume =" + Volume.ToString("0.00");
                label22.Text = "Surface Area =" + SurfaceArea.ToString("0.00");

            }
            catch
            {

            }
           
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
