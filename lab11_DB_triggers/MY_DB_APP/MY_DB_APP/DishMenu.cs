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
    public partial class DishMenu : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string menuId;
        public string type;

        public DishMenu()
        {
            InitializeComponent();
        }

        private void DishMenu_Load(object sender, EventArgs e)
        {
            textBox1.Text = type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = textBox1.Text;

            if (type != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Меню VALUES (DEFAULT, '" +
                        type + "');";
                else
                    parent.tcom = "UPDATE Меню SET Тип = '" +
                        type + "' WHERE ИД_меню = '" + menuId + "';";
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
