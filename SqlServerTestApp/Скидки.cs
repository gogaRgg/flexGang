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
    public partial class Скидки1 : Form
    {
        public Скидки1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;

            string query = "INSERT INTO dbo.Скидки ([Размер скидки],[Статус пользователя]) VALUES ('" + tb1 + "', '" + tb2 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
            [Размер скидки]
            ,[Статус пользователя]
            FROM [dbo].[Скидки]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Размер скидки", "Статус пользователя");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Скидки1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
