using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4_zad_1_forms
{
    public partial class Form1 : Form
    {
        static double B(int n)
        {
           
            if (n < 1) throw new ArgumentException();
            if (n == 1) return 5;
            return (n - 1) * (n * n + n + 1);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = "";
            double n = 0;
            n  = Convert.ToDouble(textBox2.Text);
            for (int i = 1; i <= n; ++i)
            {
                str += "" + B(i)+ ",";
                textBox1.Text = Convert.ToString(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = ""; textBox1.Text = "";
        }
    }
}
