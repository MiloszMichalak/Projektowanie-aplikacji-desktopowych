using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortowania
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

        private void losuj_Click(object sender, EventArgs e)
        {
            int ilosc = int.Parse(ileLiczb.Text);
            int[] liczbyT = losujLiczby(ilosc);
            liczby.Text = "Liczby: " + String.Join(" ", liczbyT);
            losuj.Enabled = false;
        }

        public static int[] losujLiczby(int n)
        {
            Random random = new Random();
            int[] liczby = new int[n];
            for (int i = 0; i < n; i++)
            {
                liczby[i] = random.Next(1, 100);
            }
            return liczby;
        }

        private void sort_Click(object sender, EventArgs e)
        {
            losuj.Enabled = true;

        }
    }
}
