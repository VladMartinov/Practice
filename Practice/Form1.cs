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
    
    public partial class Form1 : System.Windows.Forms.Form
    {
        static int PathTest(string path)
        {
            var exist = true;
            int Key = 0;
            if (path == "")
            {
                MessageBox.Show("Неуказан путь к файлу");
                return Key;
            }

            exist = File.Exists(path);
            if (exist == false)
            {
                MessageBox.Show("Файл не найден");
                return Key;
            }
            Key = 1;
            return Key;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public string path;
        private void Form1_Load(object sender, EventArgs e)
        {
            Gender.Items.Add("Мужской");
            Gender.Items.Add("Женский");

            LastName.Text = "Фамилия";
            LastName.ForeColor = Color.White;

            NameBox.Text = "Имя";
            NameBox.ForeColor = Color.White;

            MiddleName.Text = "Отчество";
            MiddleName.ForeColor = Color.White;

            Path.Text = "Путь";
            Path.ForeColor = Color.White;
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Текстовый файл. Файл формата  .txt | *.txt";
            if (file.ShowDialog() == DialogResult.OK)
                Path.Text = file.FileName;
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            LastName.Text = null;
            LastName.ForeColor = Color.Black;
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameBox.Text = null;
            NameBox.ForeColor = Color.Black;
        }

        private void MiddleName_Enter(object sender, EventArgs e)
        {
            MiddleName.Text = null;
            MiddleName.ForeColor = Color.Black;
        }

        private void Path_Enter(object sender, EventArgs e)
        {
            Path.Text = null;
            Path.ForeColor = Color.Black;
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text.Trim().Length == 0)
            {
                LastName.Text = "Фамилия";
                LastName.ForeColor = Color.White;
            }
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text.Trim().Length == 0)
            {
                NameBox.Text = "Имя";
                NameBox.ForeColor = Color.White;
            }
        }

        private void MiddleName_Leave(object sender, EventArgs e)
        {
            if (MiddleName.Text.Trim().Length == 0)
            {
                MiddleName.Text = "Отчество";
                MiddleName.ForeColor = Color.White;
            }
        }

        private void Path_Leave(object sender, EventArgs e)
        {
            if (Path.Text.Trim().Length == 0)
            {
                Path.Text = "Путь";
                Path.ForeColor = Color.White;
            }
        }

        private void Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol < 'А' || symbol > 'Я')
                && (symbol < 'а' || symbol > 'я')
                && symbol != '\b')
                {
                e.Handled = true;
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol < '0' || symbol > '9')           
                && symbol != '\b')
            {
                e.Handled = true;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            path = Path.Text;
            int NumItems = 0;
            if (LastName.Text == "" || NameBox.Text == "" || MiddleName.Text == "" || YearOfBirth.Text == "" || Gender.Text == "")
            {
                MessageBox.Show("Заполните все данные");
                AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                return;
            }
            if (R1.Text != "") NumItems++;
            else R1.Text = "0";
            if (R2.Text != "") NumItems++;
            else R2.Text = "0";
            if (R3.Text != "") NumItems++;
            else R3.Text = "0";
            if (R4.Text != "") NumItems++;
            else R4.Text = "0";
            if (R5.Text != "") NumItems++;
            else R5.Text = "0";
            if (R6.Text != "") NumItems++;
            else R6.Text = "0";
            if (R7.Text != "") NumItems++;
            else R7.Text = "0";
            if (R8.Text != "") NumItems++;
            else R8.Text = "0";
            if (R9.Text != "") NumItems++;
            else R9.Text = "0";
            if (NumItems < 5)
            {
                MessageBox.Show($"Указано меньше 5 предметов ({NumItems})");
                return;
            }
            if (int.Parse(YearOfBirth.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Неверный год рождения");
                AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                return;
            }
            try
            {
                using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    fstream.Close();
                }
            }
            catch
            {
                MessageBox.Show("Не получилось создать по указанному пути файл");
                return;
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{LastName.Text} {NameBox.Text} {MiddleName.Text} {YearOfBirth.Text} {Gender.Text} {R1.Text} {R2.Text} {R3.Text} {R4.Text} {R5.Text} {R6.Text} {R7.Text} {R8.Text} {R9.Text}");
                writer.Close();
            }
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;

        }

        private void CheckAllFile_Click(object sender, EventArgs e)
        {
            int NumFemale = 0;
            int NumMale = 0;
            path = Path.Text;
            if (PathTest(path) == 0)
            {
                return;
            }
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split();
                    if (line[4] == "Мужской")
                    {
                        NumFemale++;
                    }
                    if (line[4] == "Женский")
                    {
                        NumMale++;
                    }
                }
            }

            if (NumFemale >= 5 && NumMale >= 5)
            {
                FormFiles newForm = new FormFiles(path);
                newForm.Show();
            }
            else
            {
                MessageBox.Show($"Добавлено менее 10 человек ( {NumMale} - юнош, {NumFemale} - девушек )");
            }
        }

        private void Query_Click(object sender, EventArgs e)
        {
            path = Path.Text;
            if (PathTest(path) == 0)
            {
                return;
            }
            FormRequests newForm = new FormRequests(path);
            newForm.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            path = Path.Text;
            if (PathTest(path) == 0)
            {
                return;
            }
            File.WriteAllText(path, string.Empty);
        }
    }
}
