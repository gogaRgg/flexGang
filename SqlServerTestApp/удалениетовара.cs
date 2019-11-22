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
    public partial class удалениетовара : Form
    {
        public удалениетовара()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "Delete  from Товары where [id_товара]='" + n+"'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result!=null&& result>0)
            {
                MessageBox.Show("done");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id_товара]
            ,[Цена]
            ,[название]
            
            FROM [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_товара", "Цена", "название");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }
    }
}
