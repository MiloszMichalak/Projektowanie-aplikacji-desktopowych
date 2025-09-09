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
            InitializeListView();
            InitializeDataGridView();
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

        private void InitializeListView()
        {
            listView1.Columns.Add("Imie", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Plec", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("O sobie", -2, HorizontalAlignment.Right);

            for (int i = 0; i < info.Count; i++)
            {
                if (i % 3 == 0)
                {
                    ListViewItem item = new ListViewItem { Text = info[i] };
                    item.SubItems.Add(info[i + 1]);
                    item.SubItems.Add(info[i + 2]);
                    listView1.Items.Add(item);
                }
            }
        }

        private void writeUsersToText()
        {
            users.Text = String.Join("\n", info);
        }

        private void InitializeDataGridView()
        {
            for (int i = 0; i < info.Count; i++)
            {
                if (i % 3 == 0)
                {
                    dataGridView1.Rows.Add(info[i], info[i + 1], info[i + 2]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }
    }
}
