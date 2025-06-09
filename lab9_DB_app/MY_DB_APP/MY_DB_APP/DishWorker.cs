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
    public partial class DishWorker : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string dishId;
        public string workerId;

        public string id_sel1;
        public string id_sel2;

        public DishWorker()
        {
            InitializeComponent();
        }

        private void DishWorker_Load(object sender, EventArgs e)
        {
            /*
            if (workerId != "")
            {
                PG.Populate_FK_grid("Работник", dataGridView1, "ИД_работника", workerId);
                /// button3.Hide();
            }
            if (dishId != "")
            {
                PG.Populate_FK_grid("Блюдо", dataGridView2, "ИД_блюда", dishId);
                /// button4.Hide();
            }
            */
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
            if (workerId != "" && dishId != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Блюдо_работника VALUES ('" + workerId + "', '" +
                        dishId + "');";
                else
                    parent.tcom = "UPDATE Блюдо_работника " +
                        "SET ИД_работника = '" + workerId +
                        "', ИД_блюда = '" + dishId +
                        "' WHERE ИД_работника = '" + id_sel1 + "' AND ИД_блюда = '" + id_sel2 + "';";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
