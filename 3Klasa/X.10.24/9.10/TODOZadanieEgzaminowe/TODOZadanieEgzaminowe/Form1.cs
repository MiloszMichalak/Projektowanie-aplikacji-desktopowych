using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOZadanieEgzaminowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ErrorProvider error = new ErrorProvider();
        private void Check_Click(object sender, EventArgs e)
        {
            taknie.Text = "";
            error.SetError(number1, String.Empty);
            error.SetError(number2, String.Empty);

            int a;
            int b;

            bool correctNumber1 = int.TryParse(number1.Text, out a);
            bool correctNumber2 = int.TryParse(number2.Text, out b);

            if (!correctNumber1)
            {
                error.SetError(number1, "Podaj inta");
            }
            if (!correctNumber2)
            {
                error.SetError(number2, "Podaj inta");
            }

            if (correctNumber1 && correctNumber2)
            {
                if (czyZaprzyjaznione(a, b))
                {
                    taknie.Text = "Tak";
                }
                else
                {
                    taknie.Text = "Nie";
                }
            }
        }

        private static bool czyZaprzyjaznione(int a, int b)
        {
            if (sumaDzielnikow(a) == b && sumaDzielnikow(b) == a && a != b)
            {
                return true;
            }

            return false;
        }

        private static int sumaDzielnikow(int a)
        {
            int suma = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    suma += i;
                }
            }

            return suma;
        }
    }
}
