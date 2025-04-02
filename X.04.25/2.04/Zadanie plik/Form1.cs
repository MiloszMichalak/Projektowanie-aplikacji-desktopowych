namespace Zadanie_plik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text1 = textBox1.Text;
            var text2 = textBox2.Text;
            var hobby = new List<string?>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                hobby.Add(item.ToString());
            }
            var progress = hScrollBar1.Value;
            var rodzaj = comboBox1.Text;

            
        }
    }
}
