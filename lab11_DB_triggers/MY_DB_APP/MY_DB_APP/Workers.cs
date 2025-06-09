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
    public partial class Workers : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string workerId;
        public string secondName;
        public string firstName;
        public string thirdName;
        public string birthDate;
        public string job;
        public string salary;

        public Workers()
        {
            InitializeComponent();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            textBox1.Text = secondName;
            textBox2.Text = firstName;
            textBox3.Text = thirdName;
            textBox4.Text = birthDate;
            textBox5.Text = job;
            textBox6.Text = salary;
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secondName = textBox1.Text;
            string firstName = textBox2.Text;
            string thirdName = textBox3.Text;
            string birthDate = textBox4.Text;
            string job = textBox5.Text;
            string salary = textBox6.Text;

            if (secondName != "" && firstName != "" && thirdName != "" &&
                birthDate != "" && job != "" && salary != "")
            {
                if (empty_start)
                    parent.tcom = "INSERT INTO Работник VALUES (DEFAULT, " +
                        $"'{secondName}', '{firstName}', '{thirdName}', " +
                        $"'{birthDate}', '{job}', {salary});";
                else
                    parent.tcom = $"UPDATE Работник SET Фамилия = '{secondName}', " +
                        $"Имя = '{firstName}', Отчество = '{thirdName}', Дата_рождения = '{birthDate}', " +
                        $"Должность = '{job}', Зарплата = {salary} WHERE ИД_работника = '{workerId}';";
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
