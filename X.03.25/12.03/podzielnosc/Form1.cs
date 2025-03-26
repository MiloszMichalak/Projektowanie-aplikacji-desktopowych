using System.Text.RegularExpressions;

namespace podzielnosc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var regex = new Regex("^[0-9]{1,15}$");

            var rawText = textBox1.Text;

            if (regex.Match(rawText).Success)
            {
                int output = 0;
                var sum = 0;
                var f = 1;
                foreach (var x in rawText)
                {
                    int znak = Convert.ToInt32(x);
                    f *= (-1);
                    output += znak * f;
                    sum += x;

                    //if (i % 2 == 0)
                    //{
                    //    output -= text[i];
                    //}
                    //else
                    //{
                    //    output += text[i];
                    //}
                }

                label1.Text = output.ToString();
                if (output % 11 == 0)
                {
                    label1.Text = "Podzielna przez 11";
                }
            }
            else
            {
                label1.Text = "debil";
            }

            

        }
    }
}
