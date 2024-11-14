using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO2
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e) {
            string name = this.name.Text;
            string gender = getGender();
            string info = about.Text;

            saveToFile(name, gender, info);
        }

        private void saveToFile(string name, string gender, string info) {
            StreamWriter stream = new StreamWriter("../../Dane/dane.txt", true);
            stream.WriteLine(name);
            stream.WriteLine(gender);
            stream.WriteLine(info);
            stream.Close();
        }

        private string getGender() {
            if (man.Checked) {
                return "Mezczyzna";
            }
            return "Kobieta";
        }

        private void close_Click(object sender, EventArgs e) {
            Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Close();
        }
    }
}
