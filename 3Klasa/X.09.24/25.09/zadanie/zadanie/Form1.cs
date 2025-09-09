using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie
{
    public partial class nwdNww : Form
    {
        public nwdNww()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String bye = textBox1.Text;
            if (bye.ToLower() == "bay")
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Today.ToShortDateString());
            MessageBox.Show(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(this.number1.Text);
            int number2 = Convert.ToInt32(this.number2.Text);
            int nwd = NWD(number1, number2);
            int nww = (number1 * number2) / nwd;
            label1.Text = $"NWD: {nwd}, NWW: {nww}";
        }

        private static int NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
    }
}
