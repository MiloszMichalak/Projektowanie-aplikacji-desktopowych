using SimpleKalkulator;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kalkulator kalkulator = new Kalkulator();
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox1.Text);

            int output = kalkulator.Dodaj(number1, number2);
            label1.Text = $"Wynik: {output.ToString()}";
        }
    }
}
