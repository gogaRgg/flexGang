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
    public partial class Товары_у_продавца : Form
    {
        public Товары_у_продавца()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Товары_у_продавца_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_товара],[Название] from [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [id_продавца],[ФИО] from [dbo].[Продавец]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? cb1 = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
            int? cb2 = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id); ;
            int? tb1 = Convert.ToInt32(textBox1.Text);


            try
            {

                string query = $"insert into dbo.[Товары у продавца] ([id_tovara],[id_продавца],[количество данного товара]) values ({cb1},{cb2},'{tb1}')";
                int? count = DBConnectionService.SendCommandToSqlServer(query);
                MessageBox.Show("добавлен");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
             [id_продавца],[количество данного товара]
            FROM [dbo].[Товары у продавца]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "[id_продавца]", "[количество данного товара]");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }
    }
}
