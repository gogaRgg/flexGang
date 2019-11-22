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
    public partial class Удалениеклиента : Form
    {
        public Удалениеклиента()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string query = @"SELECT 
            [Фамилия]
            ,[Имя]
            ,[Отчество]
            ,[Телефон]
            ,[Email] 
            ,[Постоянный]
            FROM [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "Фамилия", "Имя", "Отчество", "Телефон", "Email", "Постоянный");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = $"{dataGridView1.CurrentRow.Cells[0].Value.ToString()} {dataGridView1.CurrentRow.Cells[1].Value.ToString()} {dataGridView1.CurrentRow.Cells[2].Value.ToString()}";
            string query = "Delete from dbo.Клиенты where [Фамилия]+' '+[Имя]+' '+[Отчество] ='" + n + "'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
                MessageBox.Show("done");
        }
    }
}
