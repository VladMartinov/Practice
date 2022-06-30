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

namespace Practice
{
    public partial class FormRequests : Form
    {
        public string path;
        public FormRequests(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListViewItem item;
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string LineInfo = reader.ReadLine();
                    string[] line = LineInfo.Split();
                    try
                    {
                        if (int.Parse(line[3]) < 2005 && line[4] == "Мужской")
                        {
                            item = new ListViewItem(line);
                            listView1.Items.Add(item);
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Не удалось считать некоторые данные из файла:\n{LineInfo}");
                    }
                }

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem item;
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split();
                    if (int.Parse(line[3]) < 2005 && line[4] == "Мужской")
                    {
                        item = new ListViewItem(line);
                        listView1.Items.Add(item);
                    }
                }

            }
        }
    }
}
