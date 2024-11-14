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
    public partial class Form2 : Form
    {
        private List<string> info = new List<string>();
        public Form2()
        {
            InitializeComponent();
            getUsersInfo();
            writeUsersToText();
        }

        private void getUsersInfo()
        {
            StreamReader sr = new StreamReader("../../Dane/dane.txt");
            while (!sr.EndOfStream)
            {
                info.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void writeUsersToText()
        {
            users.Text = String.Join("\n", info);
        }
    }
}
