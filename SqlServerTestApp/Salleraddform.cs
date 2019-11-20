using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class Salleraddform : Form
    {
        public Salleraddform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            string tb5 = textBox5.Text;
            string tb6 = textBox6.Text;
            string query = "INSERT INTO dbo.Клиенты (Фамилия, Имя,Отчество,Телефон,Email,Постоянный) VALUES ('" + tb1 + "', '" + tb2 + "','" + tb3 + "','" + tb4 + "','" + tb5 + "','" + tb6 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
