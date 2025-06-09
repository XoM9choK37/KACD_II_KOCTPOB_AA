using MY_DB_APP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PG.OpenConnection(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            }
            catch(Exception ex) { MessageBox.Show("Error!\n" + ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// PG.OpenConnection("127.0.0.1", "5432", "postgres", "123", "StudentsDB");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void работникToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Работник";
            g.pk_name = "ИД_работника";
            g.Show();
        }

        private void продуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукт";
            g.pk_name = "ИД_продукта";
            g.Show();
        }

        private void блюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюдо";
            g.pk_name = "ИД_блюда";
            g.pk_name2 = "ИД_меню";
            g.Show();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Меню";
            g.pk_name = "ИД_меню";
            g.Show();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Клиент";
            g.pk_name = "ИД_клиента";
            g.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Заказ";
            g.pk_name = "ИД_заказа";
            g.pk_name2 = "ИД_работника";
            g.Show();
        }

        private void отчToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Отчёт_о_заказах";
            g.view = true;
            g.n = (int)PG.Select_size("Отчёт_о_заказах");
            g.Show();
        }

        private void отчётОКоличествеПродуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Отчёт_о_количестве_продуктов";
            g.view = true;
            g.n = (int)PG.Select_size("Отчёт_о_количестве_продуктов");
            g.Show();
        }

        private void отчётОЗарплатахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Отчёт_о_зарплатах";
            g.view = true;
            g.n = (int)PG.Select_size("Отчёт_о_зарплатах");
            g.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

        private void заказыКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Заказ_клиента";
            g.pk_name = "ИД_заказа";
            g.pk_name2 = "ИД_клиента";
            g.Show();
        }

        private void блюдаВЗаказахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюдо_в_заказе";
            g.pk_name = "ИД_блюда";
            g.pk_name2 = "ИД_заказа";
            g.Show();
        }

        private void продуктыВБлюдахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукт_в_блюде";
            g.pk_name = "ИД_продукта";
            g.pk_name2 = "ИД_блюда";
            g.Show();
        }

        private void блюдаРаботниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюдо_работника";
            g.pk_name = "ИД_блюда";
            g.pk_name2 = "ИД_работника";
            g.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }
    }
}
