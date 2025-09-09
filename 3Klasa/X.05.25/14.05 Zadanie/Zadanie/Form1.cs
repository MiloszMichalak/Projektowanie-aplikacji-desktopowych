namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var liczba = Convert.ToInt32(textBox1.Text);

            label1.Text = "sqrt: " + Math.Sqrt(liczba);

            double output = (liczba + liczba / liczba) / 2;
            for (int i = 0; i < trackBar1.Value; i++)
            {
                output = (output + liczba / output) / 2;
            }

            label2.Text = "N-R: " + output;
        }
    }
}
