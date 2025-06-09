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
    public partial class DishOrder : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string dishId;
        public string orderId;
        public string amount;

        public string id_sel1;
        public string id_sel2;

        public DishOrder()
        {
            InitializeComponent();
        }

        private void DishOrder_Load(object sender, EventArgs e)
        {
            textBox1.Text = amount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Заказ";
            g.view = true;
            g.sel_id_name1 = "ИД_заказа";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                orderId = g.sel_id1;
                PG.Populate_FK_grid("Заказ", dataGridView1, "ИД_заказа", orderId);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = textBox1.Text;

            if (orderId != "" && dishId != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Блюдо_в_заказе VALUES ('" + orderId + "', '" +
                        dishId + "', " + amount + ");";
                else
                    parent.tcom = "UPDATE Блюдо_в_заказе " +
                        "SET ИД_заказа = '" + orderId +
                        "', ИД_блюда = '" + dishId + "', Количество_порций = " + amount +
                        " WHERE ИД_заказа = '" + id_sel1 + "' AND ИД_блюда = '" + id_sel2 + "';";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
