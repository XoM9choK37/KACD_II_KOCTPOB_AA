
namespace postgr
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зависимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдаВЗаказахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыВБлюдахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдаРаботниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётОКоличествеПродуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётОЗарплатахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "127.0.0.1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "5432";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "postgres";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "123";
            this.textBox4.UseSystemPasswordChar = true;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Database";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(94, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Cafeteria";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.зависимостиToolStripMenuItem,
            this.toolStripMenuItem3,
            this.экспортToolStripMenuItem,
            this.toolStripMenuItem4,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникToolStripMenuItem,
            this.продуктToolStripMenuItem,
            this.блюдоToolStripMenuItem,
            this.менюToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 24);
            this.toolStripMenuItem1.Text = "Справочники";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // работникToolStripMenuItem
            // 
            this.работникToolStripMenuItem.Name = "работникToolStripMenuItem";
            this.работникToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.работникToolStripMenuItem.Text = "Работники";
            this.работникToolStripMenuItem.Click += new System.EventHandler(this.работникToolStripMenuItem_Click_1);
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.продуктToolStripMenuItem.Text = "Продукты";
            this.продуктToolStripMenuItem.Click += new System.EventHandler(this.продуктToolStripMenuItem_Click);
            // 
            // блюдоToolStripMenuItem
            // 
            this.блюдоToolStripMenuItem.Name = "блюдоToolStripMenuItem";
            this.блюдоToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.блюдоToolStripMenuItem.Text = "Блюда";
            this.блюдоToolStripMenuItem.Click += new System.EventHandler(this.блюдоToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem2.Text = "Данные";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.клиентToolStripMenuItem.Text = "Клиенты";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // зависимостиToolStripMenuItem
            // 
            this.зависимостиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыКлиентовToolStripMenuItem,
            this.блюдаВЗаказахToolStripMenuItem,
            this.продуктыВБлюдахToolStripMenuItem,
            this.блюдаРаботниковToolStripMenuItem});
            this.зависимостиToolStripMenuItem.Name = "зависимостиToolStripMenuItem";
            this.зависимостиToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.зависимостиToolStripMenuItem.Text = "Зависимости";
            // 
            // заказыКлиентовToolStripMenuItem
            // 
            this.заказыКлиентовToolStripMenuItem.Name = "заказыКлиентовToolStripMenuItem";
            this.заказыКлиентовToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.заказыКлиентовToolStripMenuItem.Text = "Заказы клиентов";
            this.заказыКлиентовToolStripMenuItem.Click += new System.EventHandler(this.заказыКлиентовToolStripMenuItem_Click);
            // 
            // блюдаВЗаказахToolStripMenuItem
            // 
            this.блюдаВЗаказахToolStripMenuItem.Name = "блюдаВЗаказахToolStripMenuItem";
            this.блюдаВЗаказахToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.блюдаВЗаказахToolStripMenuItem.Text = "Блюда в заказах";
            this.блюдаВЗаказахToolStripMenuItem.Click += new System.EventHandler(this.блюдаВЗаказахToolStripMenuItem_Click);
            // 
            // продуктыВБлюдахToolStripMenuItem
            // 
            this.продуктыВБлюдахToolStripMenuItem.Name = "продуктыВБлюдахToolStripMenuItem";
            this.продуктыВБлюдахToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.продуктыВБлюдахToolStripMenuItem.Text = "Продукты в блюдах";
            this.продуктыВБлюдахToolStripMenuItem.Click += new System.EventHandler(this.продуктыВБлюдахToolStripMenuItem_Click);
            // 
            // блюдаРаботниковToolStripMenuItem
            // 
            this.блюдаРаботниковToolStripMenuItem.Name = "блюдаРаботниковToolStripMenuItem";
            this.блюдаРаботниковToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.блюдаРаботниковToolStripMenuItem.Text = "Блюда работников";
            this.блюдаРаботниковToolStripMenuItem.Click += new System.EventHandler(this.блюдаРаботниковToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчToolStripMenuItem,
            this.отчётОКоличествеПродуToolStripMenuItem,
            this.отчётОЗарплатахToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem3.Text = "Отчёты";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // отчToolStripMenuItem
            // 
            this.отчToolStripMenuItem.Name = "отчToolStripMenuItem";
            this.отчToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.отчToolStripMenuItem.Text = "Отчёт о заказах";
            this.отчToolStripMenuItem.Click += new System.EventHandler(this.отчToolStripMenuItem_Click);
            // 
            // отчётОКоличествеПродуToolStripMenuItem
            // 
            this.отчётОКоличествеПродуToolStripMenuItem.Name = "отчётОКоличествеПродуToolStripMenuItem";
            this.отчётОКоличествеПродуToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.отчётОКоличествеПродуToolStripMenuItem.Text = "Отчёт о количестве продуктов на складе";
            this.отчётОКоличествеПродуToolStripMenuItem.Click += new System.EventHandler(this.отчётОКоличествеПродуToolStripMenuItem_Click);
            // 
            // отчётОЗарплатахToolStripMenuItem
            // 
            this.отчётОЗарплатахToolStripMenuItem.Name = "отчётОЗарплатахToolStripMenuItem";
            this.отчётОЗарплатахToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.отчётОЗарплатахToolStripMenuItem.Text = "Отчёт о зарплатах";
            this.отчётОЗарплатахToolStripMenuItem.Click += new System.EventHandler(this.отчётОЗарплатахToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuItem4.Text = "О программе";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 297);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PG Connect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem работникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётОКоличествеПродуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётОЗарплатахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зависимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдаВЗаказахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыВБлюдахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдаРаботниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
    }
}

