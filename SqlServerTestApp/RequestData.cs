using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlServerTestApp
{
    public partial class RequestData : Form
    {
        public RequestData()
        {
            InitializeComponent();
        }

       

        private void ClearAndAddColumnsInDataGridView(DataGridView dataGrid, params string[] str)
        {
            dataGridView1.Rows.Clear();
            dataGrid.Columns.Clear();
            foreach (string s in str)
            {
                dataGrid.Columns.Add(s, s);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id_продавца]
            ,[ФИО]
            ,[название магазина]
            
            FROM [dbo].[Продавец]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            ClearAndAddColumnsInDataGridView(dataGridView1, "ФИО", "Название магазина");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id_клиента]
            ,[Фамилия]
            ,[Имя]
            ,[Отчество]
            FROM [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            ClearAndAddColumnsInDataGridView(dataGridView1, "id", "id1", "id2");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [dbo].[Клиенты].[id_клиента],[dbo].[Продавец].[id_продавца]
            ,[Фамилия]
            ,[Имя]
            ,[Отчество], 
             [ФИО],
             [название магазина]
           
            FROM [dbo].[Клиенты],[dbo].[Продавец],[dbo].[Продажи]
            WHERE [dbo].[Продажи].[id_продавца] = [dbo].[Продавец].[id_продавца] and [dbo].[Продажи].[id_клиента] = [dbo].[Клиенты].[id_клиента]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            ClearAndAddColumnsInDataGridView(dataGridView1, "Фамилия", "Имя", "Отчество","ФИО","название магазина");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3],row[4]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
