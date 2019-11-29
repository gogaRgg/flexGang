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
    public partial class Товар_в_продаже : Form
    {
        public Товар_в_продаже()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
             [id_продажи],[количество]
            FROM [dbo].[Товары в продаже]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "[id_продажи]", "[количество]");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Товар_в_продаже_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? cb1 = null;
            int? cb2 = null;
            int? tb1 = null;


            try
            {
                cb1 = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                cb2 = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id);
                tb1 = Convert.ToInt32(textBox1.Text);


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            string query = $"insert into dbo.[Товары в продаже] ([id_tovara],[id_продажи],[количество]) values ('{cb1}','{cb2}','{tb1}')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлен");
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_товара],[Название] from [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_продажи],[id_продажи] from [dbo].[Продажи]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }
    }
}
