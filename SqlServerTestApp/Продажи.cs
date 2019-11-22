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
    public partial class Продажи : Form
    {
        public Продажи()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_клиента],[Фамилия]+' '+[Имя]+' '+[Отчество] from [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void Продажи_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Salleraddform();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {

            string query = "select [ФИО],[название магазина] from [dbo].[Продавец]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);

        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {

            string query = "select [Цена],[название] from [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
           // string query = "select [вид оплаты],[]+' '+[название] from [dbo].[Товары]";
            //var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            var list = new IdentityItem[] {
                new IdentityItem("карта", "карта"),
                new IdentityItem("нфс", "нфс"),
                new IdentityItem("наличные", "наличные")};
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(list);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form frm2 = new Продавцы();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form frm2 = new Товары();
            frm2.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select [Цена],[название] from [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int? cb1 =null;
            int? cb2 = null;
            int? cb3 = null;
            int? cb4 = null;
            int? cb5 = null;
            DateTime? tb1 = null;
            DateTime? tb2 = null;
            try
            {
                cb1 = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                cb2 = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id);
                cb3 = Convert.ToInt32((comboBox3.SelectedItem as IdentityItem)?.Id);
                cb4 = Convert.ToInt32((comboBox4.SelectedItem as IdentityItem)?.Id);
                cb5 = Convert.ToInt32((comboBox4.SelectedItem as IdentityItem)?.Id);
                 tb1 = Convert.ToDateTime(textBox1.Text);
                 tb2 = Convert.ToDateTime(textBox2.Text);
               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            string query = $"insert into продажи ([id_клиента],[id_tovara],[id_продавца],[вид оплаты],[Дата продажи],[Дата доставки]) values ({cb1},{cb2},{cb3},{cb5},{cb4},{tb1},{tb2})";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            string query = "select[id_скидки], CAST([Размер скидки] as varchar)+' '+CAST([Статус пользователя] as varchar) from[dbo].[Скидки]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form frm2 = new Скидки1();
            frm2.Show();
            this.Hide();
        }
    }
}
