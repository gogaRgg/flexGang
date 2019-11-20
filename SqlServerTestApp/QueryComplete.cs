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
    public partial class QueryComplete : Form
    {
        public QueryComplete()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new RequestData();
            frm2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT top 1 max ([вид оплаты])
             FROM [dbo].[Продажи]
             group by [вид оплаты]
             order by [вид оплаты]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "вид оплаты");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"select [dbo].[Продавец].[ФИО], [dbo].[Клиенты].[Фамилия]+[dbo].[Клиенты].[Имя]+[dbo].[Клиенты].[Отчество]
            from [dbo].[Клиенты], [dbo].[Продавец], (Select distinct id_клиента,id_продавца
            from Продажи ) as t
where[dbo].[Продавец].[id_продавца] = t.id_продавца and[dbo].[Клиенты].[id_клиента] = t.id_клиента";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_продавца","id_товара");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }

        }


    }
}
