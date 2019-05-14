namespace SimpleStaffAccounting
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbSpot = new System.Windows.Forms.ComboBox();
            this.dtBorn = new System.Windows.Forms.DateTimePicker();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listSearch = new System.Windows.Forms.ListBox();
            this.cbSearchSpot = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearchOtch = new System.Windows.Forms.TextBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.tbSearchFam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbSpot);
            this.tabPage1.Controls.Add(this.dtBorn);
            this.tabPage1.Controls.Add(this.tbSalary);
            this.tabPage1.Controls.Add(this.tbOtch);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.tbFam);
            this.tabPage1.Controls.Add(this.btClear);
            this.tabPage1.Controls.Add(this.btAdd);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbSpot
            // 
            this.cbSpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpot.FormattingEnabled = true;
            this.cbSpot.Items.AddRange(new object[] {
            "Оператор по видеонаблюдению",
            "Программист",
            "Главный бухгалтер",
            "Директор по персоналу",
            "Системный аналитик"});
            this.cbSpot.Location = new System.Drawing.Point(131, 206);
            this.cbSpot.Name = "cbSpot";
            this.cbSpot.Size = new System.Drawing.Size(251, 24);
            this.cbSpot.TabIndex = 27;
            // 
            // dtBorn
            // 
            this.dtBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBorn.Location = new System.Drawing.Point(131, 164);
            this.dtBorn.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtBorn.Name = "dtBorn";
            this.dtBorn.Size = new System.Drawing.Size(251, 22);
            this.dtBorn.TabIndex = 26;
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSalary.Location = new System.Drawing.Point(131, 251);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(251, 22);
            this.tbSalary.TabIndex = 25;
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSalary_KeyPress);
            // 
            // tbOtch
            // 
            this.tbOtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtch.Location = new System.Drawing.Point(131, 120);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(251, 22);
            this.tbOtch.TabIndex = 24;
            this.tbOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbOtch_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(131, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 22);
            this.tbName.TabIndex = 23;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbName_KeyPress);
            // 
            // tbFam
            // 
            this.tbFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFam.Location = new System.Drawing.Point(131, 36);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(251, 22);
            this.tbFam.TabIndex = 22;
            this.tbFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFam_KeyPress);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(321, 340);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(119, 26);
            this.btClear.TabIndex = 21;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(20, 303);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(116, 43);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Оклад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата Рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фамилия";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.listSearch);
            this.tabPage2.Controls.Add(this.cbSearchSpot);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tbSearchOtch);
            this.tabPage2.Controls.Add(this.tbSearchName);
            this.tabPage2.Controls.Add(this.tbSearchFam);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listSearch
            // 
            this.listSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSearch.FormattingEnabled = true;
            this.listSearch.Location = new System.Drawing.Point(3, 211);
            this.listSearch.Name = "listSearch";
            this.listSearch.Size = new System.Drawing.Size(442, 160);
            this.listSearch.TabIndex = 10;
            // 
            // cbSearchSpot
            // 
            this.cbSearchSpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchSpot.FormattingEnabled = true;
            this.cbSearchSpot.Items.AddRange(new object[] {
            "Оператор по видеонаблюдению",
            "Программист",
            "Главный бухгалтер",
            "Директор по персоналу",
            "Системный аналитик"});
            this.cbSearchSpot.Location = new System.Drawing.Point(108, 38);
            this.cbSearchSpot.Name = "cbSearchSpot";
            this.cbSearchSpot.Size = new System.Drawing.Size(197, 24);
            this.cbSearchSpot.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Поиск по должности";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbSearchOtch
            // 
            this.tbSearchOtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchOtch.Location = new System.Drawing.Point(108, 172);
            this.tbSearchOtch.Name = "tbSearchOtch";
            this.tbSearchOtch.Size = new System.Drawing.Size(197, 22);
            this.tbSearchOtch.TabIndex = 5;
            this.tbSearchOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSearchOtch_KeyPress);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchName.Location = new System.Drawing.Point(108, 130);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(197, 22);
            this.tbSearchName.TabIndex = 4;
            this.tbSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSearchName_KeyPress);
            // 
            // tbSearchFam
            // 
            this.tbSearchFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchFam.Location = new System.Drawing.Point(108, 88);
            this.tbSearchFam.Name = "tbSearchFam";
            this.tbSearchFam.Size = new System.Drawing.Size(197, 22);
            this.tbSearchFam.TabIndex = 3;
            this.tbSearchFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSearchFam_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Фамилия";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(336, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Посмотреть всех";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта персонала";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbSpot;
        private System.Windows.Forms.DateTimePicker dtBorn;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbSearchSpot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearchOtch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchFam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listSearch;
        private System.Windows.Forms.Button button3;
    }
}

