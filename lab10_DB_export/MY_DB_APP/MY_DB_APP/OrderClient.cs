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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MY_DB_APP
{
    public partial class OrderClient : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string orderId = "";
        public string clientId = "";

        public string id_sel1 = "";
        public string id_sel2 = "";

        public OrderClient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderClient_Load(object sender, EventArgs e)
        {
            /*
            if (orderId != "")
            {
                PG.Populate_FK_grid("Заказ", dataGridView1, "ИД_заказа", orderId);
                /// button3.Hide();
            }
            if (clientId != "")
            {
                PG.Populate_FK_grid("Клиент", dataGridView2, "ИД_клиента", clientId);
                /// button4.Hide();
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orderId != "" && clientId != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Заказ_клиента VALUES ('" + clientId + "', '" +
                        orderId + "');";
                else
                    parent.tcom = "UPDATE Заказ_клиента " +
                        "SET ИД_заказа = '" + orderId +
                        "', ИД_клиента = '" + clientId +
                        "' WHERE ИД_заказа = '" + id_sel1 + "' AND ИД_клиента = '" + id_sel2 + "';";

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
            g.table = "Клиент";
            g.view = true;
            g.sel_id_name2 = "ИД_клиента";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                clientId = g.sel_id2;
                PG.Populate_FK_grid("Клиент", dataGridView2, "ИД_клиента", clientId);
            }
        }
    }
}
