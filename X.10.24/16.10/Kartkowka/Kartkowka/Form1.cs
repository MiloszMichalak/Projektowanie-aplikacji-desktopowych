using System;
using System.Windows.Forms;

namespace Kartkowka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            string number1 = this.number1.Text;
            string number2 = this.number2.Text;

            blad.Text = "";

            if (number1.Length != 2 || number2.Length != 2)
            {
                blad.Text = "Liczby musza byc 2 cyfrowe";
                this.number1.Text = "";
                this.number2.Text = "";
            }
            else
            {
                int sumaBulgarska = sumaCyfr(int.Parse(number1)) + sumaCyfr(int.Parse(number2));
                if (czyPierwsza(sumaBulgarska))
                {
                    MessageBox.Show("Sukces");
                }
                else
                {
                    MessageBox.Show("Porazka");
                }
            }
        }

        private int sumaCyfr(int number)
        {
            int suma = 0;
            while (number > 0)
            {
                suma += number % 10;
                number /= 10;
            }

            return suma;
        }

        private bool czyPierwsza(int number)
        {
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
