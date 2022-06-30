namespace Practice
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.YearOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.R1 = new System.Windows.Forms.TextBox();
            this.R2 = new System.Windows.Forms.TextBox();
            this.R3 = new System.Windows.Forms.TextBox();
            this.R4 = new System.Windows.Forms.TextBox();
            this.R5 = new System.Windows.Forms.TextBox();
            this.R6 = new System.Windows.Forms.TextBox();
            this.R7 = new System.Windows.Forms.TextBox();
            this.R8 = new System.Windows.Forms.TextBox();
            this.R9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.openFile = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            this.CheckAllFiles = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.NameBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.YearOfBirth, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Path, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Gender, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MiddleName, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NameBox.Location = new System.Drawing.Point(251, 66);
            this.NameBox.Margin = new System.Windows.Forms.Padding(22, 33, 22, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(192, 22);
            this.NameBox.TabIndex = 6;
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Field_KeyPress);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(468, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(232, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год рождения";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(232, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пол";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LastName.Location = new System.Drawing.Point(22, 66);
            this.LastName.Margin = new System.Windows.Forms.Padding(22, 33, 22, 5);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(185, 22);
            this.LastName.TabIndex = 5;
            this.LastName.Enter += new System.EventHandler(this.LastName_Enter);
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Field_KeyPress);
            this.LastName.Leave += new System.EventHandler(this.LastName_Leave);
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearOfBirth.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.YearOfBirth.Location = new System.Drawing.Point(22, 178);
            this.YearOfBirth.Margin = new System.Windows.Forms.Padding(22, 33, 22, 5);
            this.YearOfBirth.Mask = "0000";
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Size = new System.Drawing.Size(185, 22);
            this.YearOfBirth.TabIndex = 11;
            this.YearOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Location = new System.Drawing.Point(468, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(225, 33);
            this.label16.TabIndex = 10;
            this.label16.Text = "Путь к файлу";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Path
            // 
            this.Path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Path.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Path.Location = new System.Drawing.Point(487, 178);
            this.Path.Margin = new System.Windows.Forms.Padding(22, 33, 22, 5);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(187, 22);
            this.Path.TabIndex = 13;
            this.Path.Enter += new System.EventHandler(this.Path_Enter);
            this.Path.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Field_KeyPress);
            this.Path.Leave += new System.EventHandler(this.Path_Leave);
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(251, 178);
            this.Gender.Margin = new System.Windows.Forms.Padding(22, 33, 22, 5);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(192, 23);
            this.Gender.TabIndex = 12;
            // 
            // MiddleName
            // 
            this.MiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddleName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MiddleName.Location = new System.Drawing.Point(487, 66);
            this.MiddleName.Margin = new System.Windows.Forms.Padding(22, 33, 22, 5);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(187, 22);
            this.MiddleName.TabIndex = 7;
            this.MiddleName.Enter += new System.EventHandler(this.MiddleName_Enter);
            this.MiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Field_KeyPress);
            this.MiddleName.Leave += new System.EventHandler(this.MiddleName_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.R1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.R2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.R3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.R4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.R5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.R6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.R7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.R8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.R9, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 273);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 232);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // R1
            // 
            this.R1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R1.Location = new System.Drawing.Point(48, 3);
            this.R1.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R1.MaxLength = 3;
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(78, 22);
            this.R1.TabIndex = 10;
            this.R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R2
            // 
            this.R2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R2.Location = new System.Drawing.Point(48, 30);
            this.R2.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R2.MaxLength = 3;
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(78, 22);
            this.R2.TabIndex = 14;
            this.R2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R3
            // 
            this.R3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R3.Location = new System.Drawing.Point(48, 55);
            this.R3.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R3.MaxLength = 3;
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(78, 22);
            this.R3.TabIndex = 15;
            this.R3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R4
            // 
            this.R4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R4.Location = new System.Drawing.Point(48, 80);
            this.R4.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R4.MaxLength = 3;
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(78, 22);
            this.R4.TabIndex = 16;
            this.R4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R5
            // 
            this.R5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R5.Location = new System.Drawing.Point(48, 105);
            this.R5.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R5.MaxLength = 3;
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(78, 22);
            this.R5.TabIndex = 17;
            this.R5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R6
            // 
            this.R6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R6.Location = new System.Drawing.Point(48, 130);
            this.R6.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R6.MaxLength = 3;
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(78, 22);
            this.R6.TabIndex = 18;
            this.R6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R7
            // 
            this.R7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R7.Location = new System.Drawing.Point(48, 155);
            this.R7.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R7.MaxLength = 3;
            this.R7.Name = "R7";
            this.R7.Size = new System.Drawing.Size(78, 22);
            this.R7.TabIndex = 19;
            this.R7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R8
            // 
            this.R8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R8.Location = new System.Drawing.Point(48, 180);
            this.R8.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R8.MaxLength = 3;
            this.R8.Name = "R8";
            this.R8.Size = new System.Drawing.Size(78, 22);
            this.R8.TabIndex = 20;
            this.R8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // R9
            // 
            this.R9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.R9.Location = new System.Drawing.Point(48, 205);
            this.R9.Margin = new System.Windows.Forms.Padding(48, 3, 48, 3);
            this.R9.MaxLength = 3;
            this.R9.Name = "R9";
            this.R9.Size = new System.Drawing.Size(78, 22);
            this.R9.TabIndex = 21;
            this.R9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(177, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Русский язык";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(177, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Мат. Логика ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(177, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Иностранный язык ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Location = new System.Drawing.Point(177, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Физика";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(177, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Математика";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(177, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Информатика";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Location = new System.Drawing.Point(177, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Программирование";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Location = new System.Drawing.Point(177, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 30);
            this.label14.TabIndex = 13;
            this.label14.Text = "Физкультура";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(177, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дискретная математика";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.71449F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.28551F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.Controls.Add(this.openFile, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(697, 45);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.openFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.openFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFile.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.openFile.Location = new System.Drawing.Point(515, 10);
            this.openFile.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(132, 25);
            this.openFile.TabIndex = 6;
            this.openFile.Text = "Путь к файлу";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(459, 45);
            this.label15.TabIndex = 0;
            this.label15.Text = "Оценки";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.ClearButton, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.QueryButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.CheckAllFiles, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(350, 273);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(351, 232);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClearButton.Location = new System.Drawing.Point(57, 188);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(57, 14, 57, 14);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(237, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.QueryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.QueryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.QueryButton.Location = new System.Drawing.Point(57, 130);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(57, 14, 57, 14);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(237, 30);
            this.QueryButton.TabIndex = 4;
            this.QueryButton.Text = "По запросу";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.Query_Click);
            // 
            // CheckAllFiles
            // 
            this.CheckAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAllFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.CheckAllFiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckAllFiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckAllFiles.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckAllFiles.Location = new System.Drawing.Point(57, 72);
            this.CheckAllFiles.Margin = new System.Windows.Forms.Padding(57, 14, 57, 14);
            this.CheckAllFiles.Name = "CheckAllFiles";
            this.CheckAllFiles.Size = new System.Drawing.Size(237, 30);
            this.CheckAllFiles.TabIndex = 2;
            this.CheckAllFiles.Text = "Просмотр всего файла";
            this.CheckAllFiles.UseVisualStyleBackColor = false;
            this.CheckAllFiles.Click += new System.EventHandler(this.CheckAllFile_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddButton.Location = new System.Drawing.Point(57, 14);
            this.AddButton.Margin = new System.Windows.Forms.Padding(57, 14, 57, 14);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(237, 30);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(700, 504);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(718, 551);
            this.Name = "Form1";
            this.Text = "List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox R9;
        private System.Windows.Forms.TextBox R8;
        private System.Windows.Forms.TextBox R7;
        private System.Windows.Forms.TextBox R6;
        private System.Windows.Forms.TextBox R5;
        private System.Windows.Forms.TextBox R4;
        private System.Windows.Forms.TextBox R3;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Button CheckAllFiles;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox YearOfBirth;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button openFile;
    }
}

