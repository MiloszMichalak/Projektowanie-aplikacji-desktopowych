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

            bool isValidData = ValidateData(info, gender, name);

            if (isValidData)
            {
                saveToFile(name, gender, info);
                MessageBox.Show("Zapisalo cie w bazie danych");
            }
        }

        private bool ValidateData(string info, string gender, string name)
        {
            if (name.Length > 0 && info.Length > 0 && gender != null)
            {
                return true;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Musisz zaznaczyc plec");
            }
            else if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Musisz podac imie");
            }
            else
            {
                MessageBox.Show("Musisz podac informacje o sobie");
            }

            return false;
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
            if (Woman.Checked)
            {
                return "Kobieta";
            }
            return null;
        }

        private void close_Click(object sender, EventArgs e) {
            Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
