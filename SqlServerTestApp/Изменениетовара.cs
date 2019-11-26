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
    public partial class Изменениетовара : Form
    {
        public Изменениетовара()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id_товара]
            ,[название]
            ,[Цена]
           
            FROM [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_товара", "название", "Цена");
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
                mn = textBox1.Text;
                nm = textBox2.Text;

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Товары SET Цена='"+mn+"',название='"+nm+"' where id_товара='" +n+ "'" ;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Updated");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form frm2 = new Изменение();
            frm2.Show();
            this.Hide();
        }
    }
}
