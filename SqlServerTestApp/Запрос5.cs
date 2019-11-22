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
    public partial class Запрос5 : Form
    {
        public Запрос5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT  
            [название]
            FROM [dbo].[Товары]
           where [id_товара] not in (select [id_товара] from [Продажи])";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1,"название");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = @"SELECT distinct [id_товара],
            [название]
            FROM [dbo].[Товары], (select Продажи.[id_tovara] from Продажи) as t
           where Товары.id_товара = t.id_tovara";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_товара","название");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form frm2 = new QueryComplete();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
