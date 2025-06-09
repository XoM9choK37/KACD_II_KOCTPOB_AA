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
    public partial class Products : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string productId;
        public string name;
        public string supplier;
        public string price;
        public string amount;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = supplier;
            textBox3.Text = price;
            textBox4.Text = amount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string supplier = textBox2.Text;
            string price = textBox3.Text;
            string amount = textBox4.Text;            

            if (name != "" && supplier != "" && price != "" && amount != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Продукт VALUES (DEFAULT, " +
                        $"'{name}', " +
                        $"'{supplier}', {price}, {amount});";
                else
                    parent.tcom = $"UPDATE Продукт SET Название = '{name}', " +
                        $"Поставщик = '{supplier}', Цена = {price}, Количество = {amount} " +
                        $"WHERE ИД_продукта = '{productId}';";
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
