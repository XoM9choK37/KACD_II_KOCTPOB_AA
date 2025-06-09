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
    public partial class Clients : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string id;
        public string phone;

        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            textBox1.Text = phone;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string phone = textBox1.Text;

            if (phone != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Клиент VALUES (DEFAULT, '" +
                        phone + "');";
                else
                    parent.tcom = "UPDATE Клиент SET Номер_телефона = '" +
                        phone + "' WHERE ИД_клиента = '" + id + "';";
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
