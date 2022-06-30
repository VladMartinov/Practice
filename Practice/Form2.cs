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
    public partial class FormFiles : System.Windows.Forms.Form
    {
        public string path;
        public FormFiles(string path)
        {
            InitializeComponent();
            this.path = path;

        }

        private void FormFiles_Load(object sender, EventArgs e)
        {
            ListViewItem item;
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split();
                    item = new ListViewItem(line);
                    listView1.Items.Add(item);
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split();
                    item = new ListViewItem(line);
                    listView1.Items.Add(item);

                }
            }
        }
    }
}
