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
    public partial class Измемениепродавца : Form
    {
        public Измемениепродавца()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id_продавца]
            ,[ФИО]
            ,[название магазина]
           
            FROM [dbo].[Продавец]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_товара", "ФИО", "название магазина");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mn = null;
            string nm = null;
            try
            {
                int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = "update dbo.Продавец SET ФИО='" + mn + "',[название магазина]='" + nm + "' where id_продавца='" + n + "'";
                int? result = DBConnectionService.SendCommandToSqlServer(query);
                if (result != null && result > 0)
                {
                    MessageBox.Show("Updated");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Изменение>();
        }
    }
}
