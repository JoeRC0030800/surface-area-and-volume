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
    }
}
