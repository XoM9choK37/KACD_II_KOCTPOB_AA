using postgr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DB_APP
{
    public partial class Dishes : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string dishId;
        public string menuId;
        public string name;
        public string weight;
        public string price;

        public Dishes()
        {
            InitializeComponent();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {
            textBox2.Text = name;
            textBox3.Text = weight;
            textBox4.Text = price;

            /*
            if (menuId != "")
            {
                PG.Populate_FK_grid("Меню", dataGridView1, "ИД_меню", menuId);
                button3.Hide();
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string weight = textBox3.Text;
            string price = textBox4.Text;

            if (name != "" && weight != "" && price != "" && menuId != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Блюдо VALUES (DEFAULT, " +
                        $"'{menuId}', " +
                        $"'{name}', {weight}, {price});";
                else
                    parent.tcom = $"UPDATE Блюдо SET ИД_меню = '{menuId}', " +
                        $"Название = '{name}', Масса_порции = {weight}, Цена = {price} " +
                        $"WHERE ИД_блюда = '{dishId}';";
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Меню";
            g.view = true;
            g.sel_id_name1 = "ИД_меню";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                menuId = g.sel_id1;
                PG.Populate_FK_grid("Меню", dataGridView1, "ИД_меню", menuId);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
