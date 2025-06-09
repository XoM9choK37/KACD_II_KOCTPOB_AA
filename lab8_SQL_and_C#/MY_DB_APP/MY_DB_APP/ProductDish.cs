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
    public partial class ProductDish : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string productId;
        public string dishId;
        public string amount;

        public string id_sel1;
        public string id_sel2;

        public ProductDish()
        {
            InitializeComponent();
        }

        private void ProductDish_Load(object sender, EventArgs e)
        {
            textBox1.Text = amount;

            /*
            if (productId != "")
            {
                PG.Populate_FK_grid("Продукт", dataGridView1, "ИД_продукта", productId);
                /// button3.Hide();
            }
            if (dishId != "")
            {
                PG.Populate_FK_grid("Блюдо", dataGridView2, "ИД_блюда", dishId);
                /// button4.Hide();
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюдо";
            g.view = true;
            g.sel_id_name2 = "ИД_блюда";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                dishId = g.sel_id2;
                PG.Populate_FK_grid("Блюдо", dataGridView2, "ИД_блюда", dishId);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукт";
            g.view = true;
            g.sel_id_name1 = "ИД_продукта";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                productId = g.sel_id1;
                PG.Populate_FK_grid("Продукт", dataGridView1, "ИД_продукта", productId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = textBox1.Text;

            if (productId != "" && dishId != "" && amount != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Продукт_в_блюде VALUES ('" + productId + "', '" +
                        dishId + "', " + amount + ");";
                else
                    parent.tcom = "UPDATE Продукт_в_блюде " +
                        "SET ИД_продукта = '" + productId +
                        "', ИД_блюда = '" + dishId + "', Количество_продукта = " + amount +
                        " WHERE ИД_продукта = '" + id_sel1 + "' AND ИД_блюда = '" + id_sel2 + "';";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
