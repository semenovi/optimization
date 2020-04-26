using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace solution
{
    public partial class form_optimization : Form
    {
        public form_optimization()
        {
            InitializeComponent();
        }

        private void text_x0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void text_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void text_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void text_d1_x0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void text_d1_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void text_d2_x0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void text_d2_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
            if (e.KeyChar == 46)
                e.Handled = false;
        }

        private void button_calculate_powell_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(text_x0.Text);
            double x1 = Convert.ToDouble(text_x1.Text);
            double eps = Convert.ToDouble(text_e.Text);
            double d10 = Convert.ToDouble(text_d1_x0.Text);
            double d11 = Convert.ToDouble(text_d1_x1.Text);
            double d20 = Convert.ToDouble(text_d2_x0.Text);
            double d21 = Convert.ToDouble(text_d2_x1.Text);

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            long frequency = Stopwatch.Frequency;
            long nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
            sw.Start();
            powell exec = new powell(x0, x1, eps, d10, d11, d20, d21);
            exec.calculate();
            sw.Stop();
            text_powell_output.Text = "x*=" + Convert.ToString(exec.x0min) + ", y*=" + Convert.ToString(exec.x1min);
            text_powell_time.Text = Convert.ToString(sw.ElapsedTicks / nanosecPerTick) + " нс";
        }
    }
}
