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
    public partial class Last : Form
    {
        public Last()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm2 = new JustForm();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = @"select (ФИО)
from Продажи,[Товары в продаже],[dbo].[Товары], [dbo].[Продавец]
where Продажи.id_продажи=[Товары в продаже].id_продажи and Продажи.id_продавца=Продавец.id_продавца and Продажи.id_tovara=[Товары в продаже].id_tovara and Продажи.id_tovara=[Товары].id_товара";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ФИО");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"select (ФИО)
from Продажи,[Товары в продаже],[dbo].[Товары], [dbo].[Продавец]
where Продажи.id_продажи!=[Товары в продаже].id_продажи and Продажи.id_продавца!=Продавец.id_продавца and Продажи.id_tovara!=[Товары в продаже].id_tovara and Продажи.id_tovara!=[Товары].id_товара
group by ФИО";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ФИО");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"select[dbo].[Продавец].id_продавца
from[dbo].[Продавец]
where[dbo].[Продавец].id_продавца IN(select distinct [dbo].[Продажи].id_продавца
from [dbo].[Продажи])
";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_продавца");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"select [dbo].[Продавец].id_продавца
from [dbo].[Продавец]
where [dbo].[Продавец].id_продавца not IN (select distinct [dbo].[Продажи].id_продавца
from [dbo].[Продажи])
";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_продавца");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }
    }
}
