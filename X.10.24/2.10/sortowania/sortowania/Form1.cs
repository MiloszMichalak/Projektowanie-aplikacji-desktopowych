using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace sortowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private int[] liczbyT;
        private void losuj_Click(object sender, EventArgs e)
        {
            int ilosc = int.Parse(ileLiczb.Text);
            liczbyT = losujLiczby(ilosc);
            liczby.Text = "Liczby: " + String.Join(" ", liczbyT);
            losuj.Enabled = false;
            groupBox1.Enabled = true;
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
            int[] sortedArray = new int[0];
            if (bubble.Checked)
            {
                sortedArray = Sortowanie.BubbleSort(liczbyT);
            }

            if (hoare.Checked)
            {
                sortedArray = Sortowanie.HoareSort(liczbyT, 0, liczbyT.Length - 1);
            }

            if (lomuto.Checked)
            {
                sortedArray = Sortowanie.LomutoSort(liczbyT, 0, liczbyT.Length - 1);
            }
            posortowanaTablica.Text = "Posortowane: " + string.Join(" ", sortedArray);
            groupBox1.Enabled = false;
        }
    }
}