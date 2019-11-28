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
    public partial class Товар_на_складе : Form
    {
        public Товар_на_складе()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_товара],[название] from [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_склада],[адрес] from [dbo].[Склад]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? cb1 = null;
            int? cb2 = null;
            string tb1 = null;
            
           
            try
            {
                cb1 = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                cb2 = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id);
                tb1 = Convert.ToString(textBox1.Text);
             

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            string query = $"insert into dbo.Склад ([id_tovara],[id_склада],[количество]) values ({cb1},{cb2},'{tb1}')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
            [адрес]
            FROM [dbo].[Склад]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "адрес");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
