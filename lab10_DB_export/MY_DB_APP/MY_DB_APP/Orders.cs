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
    public partial class Orders : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string orderId;
        public string workerId;
        public string creationDate;

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            textBox2.Text = creationDate;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Работник";
            g.view = true;
            g.sel_id_name1 = "ИД_работника";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                workerId = g.sel_id1;
                PG.Populate_FK_grid("Работник", dataGridView1, "ИД_работника", workerId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string creationDate = textBox2.Text;

            if (creationDate != "" && workerId != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Заказ VALUES (DEFAULT, " +
                        $"'{workerId}', " +
                        $"'{creationDate}');";
                else
                    parent.tcom = $"UPDATE Заказ SET ИД_работника = '{workerId}', " +
                        $"Дата_и_время_создания = '{creationDate}' " +
                        $"WHERE ИД_заказа = '{orderId}';";
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
