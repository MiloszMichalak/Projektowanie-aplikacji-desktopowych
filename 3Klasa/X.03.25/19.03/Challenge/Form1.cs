namespace Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = Convert.ToInt32(textBox1.Text);
            while (number > 0)
            {
                // dec to bin

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var numbers = textBox2.Text.Split(",");
            int maks = intListToStrList(numbers).Max();
            var output = new int[maks];
            for (int i = 0; i < maks - 1; i++)
            {
                output[i] = 0;
            }
            foreach (var number in numbers)
            {
                output[Convert.ToInt16(number) - 1] = 1;
            }

            label2.Text = binToDec(string.Join("", output)).ToString();

        }

        private int[] intListToStrList(string[] lista)
        {
            int[] lista2 = new int[lista.Length];
            for (int i = 0; i < lista.Length; i++)
            {
                lista2[i] = Convert.ToInt32(lista[i]);
            }
            return lista2;
        }

        private double binToDec(string bin)
        {
            var potega = 1;
            var output = 0.0;
            for (int i = bin.Length - 1; i > 0; i--)
            {
                if (Convert.ToInt32(bin[i]) == 1)
                {
                    output += Math.Pow(2, potega);
                }
                potega++;
            }

            return output;
        }
    }
}
