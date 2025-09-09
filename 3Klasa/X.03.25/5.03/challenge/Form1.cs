using System.Text.RegularExpressions;

namespace challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = new List<int>();

            Regex regex = new Regex("^[0-9]{7,9}$");
            string text = textBox1.Text;

            if (!regex.IsMatch(text))
            {
                return;
            }

            while (text != string.Empty)
            {
                var lastTwo = Convert.ToInt32(text.Substring(text.Length - 2));

                var howMany = lastTwo / 7;
                var iloczyn = howMany * 7;

                var modulo = lastTwo - iloczyn;
                label1.Text = modulo.ToString();
            }
        }
    }
}
