using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4_zad_2_forms_1_
{
    public partial class Form1 : Form
    {
        static void F(double q, double b, double n, out double fn, out double sum)
        {
            if (n > 1)
            {
                F(q, b, n - 1, out fn, out sum);
                fn = fn * q;
                sum += fn;

            }
            else { fn = b; sum = b; };
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = 0, q = 0, n = 0;
            b = Convert.ToDouble(textBox1.Text);
            q = Convert.ToDouble(textBox2.Text);
            n = Convert.ToDouble(textBox3.Text);
            double sum;
            double fn;
            F(q, b, n, out fn, out sum);
            textBox4.Text = Convert.ToString(fn);
            textBox5.Text = Convert.ToString(sum);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
        }
    }
}
