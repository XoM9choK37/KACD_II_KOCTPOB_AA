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
    public partial class CRUD : Form
    {
        public bool view = false;
        public bool allow_upd = true;
        public string table = "";
        public string pk_name = "";
        public string pk_name2 = "";
        public int n = 10;

        public string tcom = "";

        public string sel_id_name1 = "";
        public string sel_id1 = "";
        public string sel_id_name2 = "";
        public string sel_id2 = "";

        private int sz = 0;
        private int pages = 0;

        public CRUD()
        {
            InitializeComponent();
        }

        private void resize()
        {
            if (table != "")
            {
                sz = (int)PG.Select_size(table);
                pages = sz / n + (sz % n == 0 ? 0 : 1);
            }
        }

        private void reload_view()
        {
            int pg = Convert.ToInt32(textBox1.Text);
            if (table != "")
                PG.Populate_grid(table, dataGridView1, n, pg - 1);
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            resize();
            reload_view();
            if (view)
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
            }
            if (!allow_upd) button2.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int pg;
            try
            {
                pg = Convert.ToInt32(textBox1.Text);
                if (pg < 1 || pg > pages) throw new Exception("pg");
            }
            catch (Exception)
            {
                pg = 1;
                textBox1.Text = "1";
            }
            textBox1.Text = pg.ToString();
            reload_view();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (table == "Работник")
                {
                    Workers s = new Workers();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Продукт")
                {
                    Products s = new Products();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Блюдо")
                {
                    Dishes s = new Dishes();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Меню")
                {
                    DishMenu s = new DishMenu();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Клиент")
                {
                    Clients s = new Clients();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Заказ")
                {
                    Orders s = new Orders();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Заказ_клиента")
                {
                    OrderClient s = new OrderClient();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Блюдо_в_заказе")
                {
                    DishOrder s = new DishOrder();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Блюдо_работника")
                {
                    DishWorker s = new DishWorker();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Продукт_в_блюде")
                {
                    ProductDish s = new ProductDish();
                    s.parent = this;
                    s.empty_start = true;
                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    if (table == "Работник")
                    {
                        Workers s = new Workers();
                        s.parent = this;
                        s.empty_start = false;

                        s.workerId = (string)dataGridView1.SelectedRows[0].Cells["ИД_работника"].Value;
                        s.secondName = (string)dataGridView1.SelectedRows[0].Cells["Фамилия"].Value;
                        s.firstName = (string)dataGridView1.SelectedRows[0].Cells["Имя"].Value;
                        s.thirdName = (string)dataGridView1.SelectedRows[0].Cells["Отчество"].Value;
                        s.birthDate = (string)dataGridView1.SelectedRows[0].Cells["Дата_рождения"].Value;
                        s.job = (string)dataGridView1.SelectedRows[0].Cells["Должность"].Value;
                        s.salary = (string)dataGridView1.SelectedRows[0].Cells["Зарплата"].Value;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Продукт")
                    {
                        Products s = new Products();
                        s.parent = this;
                        s.empty_start = false;

                        s.productId = (string)dataGridView1.SelectedRows[0].Cells["ИД_продукта"].Value;
                        s.name = (string)dataGridView1.SelectedRows[0].Cells["Название"].Value;
                        s.supplier = (string)dataGridView1.SelectedRows[0].Cells["Поставщик"].Value;
                        s.price = (string)dataGridView1.SelectedRows[0].Cells["Цена"].Value;
                        s.amount = (string)dataGridView1.SelectedRows[0].Cells["Количество"].Value;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Блюдо")
                    {
                        Dishes s = new Dishes();
                        s.parent = this;
                        s.empty_start = false;

                        s.dishId = (string)dataGridView1.SelectedRows[0].Cells["ИД_блюда"].Value;
                        s.menuId = (string)dataGridView1.SelectedRows[0].Cells["ИД_меню"].Value;
                        s.name = (string)dataGridView1.SelectedRows[0].Cells["Название"].Value;
                        s.weight = (string)dataGridView1.SelectedRows[0].Cells["Масса_порции"].Value;
                        s.price = (string)dataGridView1.SelectedRows[0].Cells["Цена"].Value;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Меню")
                    {
                        DishMenu s = new DishMenu();
                        s.parent = this;
                        s.empty_start = false;

                        s.menuId = (string)dataGridView1.SelectedRows[0].Cells["ИД_меню"].Value;
                        s.type = (string)dataGridView1.SelectedRows[0].Cells["Тип"].Value;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Клиент")
                    {
                        Clients s = new Clients();
                        s.parent = this;
                        s.empty_start = false;

                        s.id = (string)dataGridView1.SelectedRows[0].Cells["ИД_клиента"].Value;
                        s.phone = (string)dataGridView1.SelectedRows[0].Cells["Номер_телефона"].Value;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Заказ")
                    {
                        Orders s = new Orders();
                        s.parent = this;
                        s.empty_start = false;

                        s.orderId = (string)dataGridView1.SelectedRows[0].Cells["ИД_заказа"].Value;
                        s.workerId = (string)dataGridView1.SelectedRows[0].Cells["ИД_работника"].Value;
                        s.creationDate = (string)dataGridView1.SelectedRows[0].Cells["Дата_и_время_создания"].Value;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Заказ_клиента")
                    {
                        OrderClient s = new OrderClient();
                        s.parent = this;
                        s.empty_start = false;

                        s.orderId = (string)dataGridView1.SelectedRows[0].Cells["ИД_заказа"].Value;
                        s.clientId = (string)dataGridView1.SelectedRows[0].Cells["ИД_клиента"].Value;

                        s.id_sel1 = s.orderId;
                        s.id_sel2 = s.clientId;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Блюдо_в_заказе")
                    {
                        DishOrder s = new DishOrder();
                        s.parent = this;
                        s.empty_start = false;

                        s.dishId = (string)dataGridView1.SelectedRows[0].Cells["ИД_блюда"].Value;
                        s.orderId = (string)dataGridView1.SelectedRows[0].Cells["ИД_заказа"].Value;

                        s.id_sel1 = s.orderId;
                        s.id_sel2 = s.dishId;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Блюдо_работника")
                    {
                        DishWorker s = new DishWorker();
                        s.parent = this;
                        s.empty_start = false;

                        s.dishId = (string)dataGridView1.SelectedRows[0].Cells["ИД_блюда"].Value;
                        s.workerId = (string)dataGridView1.SelectedRows[0].Cells["ИД_работника"].Value;

                        s.id_sel1 = s.workerId;
                        s.id_sel2 = s.dishId;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                    if (table == "Продукт_в_блюде")
                    {
                        ProductDish s = new ProductDish();
                        s.parent = this;
                        s.empty_start = false;

                        s.productId = (string)dataGridView1.SelectedRows[0].Cells["ИД_продукта"].Value;
                        s.dishId = (string)dataGridView1.SelectedRows[0].Cells["ИД_блюда"].Value;
                        s.amount = (string)dataGridView1.SelectedRows[0].Cells["Количество_продукта"].Value;

                        s.id_sel1 = s.productId;
                        s.id_sel2 = s.dishId;

                        DialogResult d = s.ShowDialog();
                        if (d == DialogResult.OK)
                        {
                            PG.SendCU(tcom);
                            resize();
                            reload_view();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (table != "" && pk_name != "" && pk_name2 != "")
                {
                    foreach (DataGridViewRow x in dataGridView1.SelectedRows)
                        PG.Delete2(table, pk_name, (string)x.Cells[pk_name].Value,
                            pk_name2, (string)x.Cells[pk_name2].Value);
                }
                else if (table != "" && pk_name != "")
                {
                    foreach (DataGridViewRow x in dataGridView1.SelectedRows)
                        PG.Delete(table, pk_name, (string)x.Cells[pk_name].Value);
                }
                resize();
                reload_view();
                if (dataGridView1.Rows.Count == 0)
                {
                    int pg = Convert.ToInt32(textBox1.Text);
                    if (pg > 1) textBox1.Text = (pg - 1).ToString();
                    reload_view();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pg = Convert.ToInt32(textBox1.Text);
            if (pg > 1) textBox1.Text = (pg - 1).ToString();
            reload_view();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pg = Convert.ToInt32(textBox1.Text);
            if (pg < pages) textBox1.Text = (pg + 1).ToString();
            reload_view();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && sel_id_name1 != "")
                sel_id1 = (string)dataGridView1.SelectedRows[0].Cells[sel_id_name1].Value;
            if (dataGridView1.SelectedRows.Count != 0 && sel_id_name2 != "")
                sel_id2 = (string)dataGridView1.SelectedRows[0].Cells[sel_id_name2].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
