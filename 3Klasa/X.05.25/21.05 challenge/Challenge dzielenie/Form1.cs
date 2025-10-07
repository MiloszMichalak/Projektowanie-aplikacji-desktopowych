using System.Text.RegularExpressions;

namespace Challenge_dzielenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsMatch(string number)
        {
            var pattern = "^\\d{7, 9}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(number);
        }

        private bool checkDivisable(int number)
        {
            while (number >= 0)
            {
                if (number == 0)
                {
                    return true;
                }
                number -= 11;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = textBox1.Text;
            if (!IsMatch(number))
            {
                label1.Text = "Musi byc liczba majaca 7 do 9 cyfr";
                return;
            }

            var evenSum = 0;
            var oddSum = 0;
            foreach (var t in number)
            {
                if (t % 2 == 0)
                {
                    evenSum += t - '0';
                }
                else
                {
                    oddSum += t - '0';
                }
            }

            var difference = evenSum - oddSum;
            if (checkDivisable(difference))
            {
                label2.Text = "Podzielne";
            }
            else
            {
                label2.Text = "Nie podzielne";
            }
        }
    }
}
