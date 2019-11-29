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
    public partial class изменение_склада : Form
    {
        public изменение_склада()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
[id_склада],
            [адрес]
            FROM [dbo].[Склад]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_склада","адрес");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string zz = null;
            
            try
            {
                int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = "update dbo.Склад SET адрес='" + zz + "' where id_склада='" + n + "'";
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

        private void изменение_склада_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
