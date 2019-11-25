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
    public partial class Склад : Form
    {
        public Склад()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string query = "INSERT INTO dbo.Склад (адрес) VALUES ('" + tb1 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
            [адрес]
            FROM [dbo].[Склад]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "адрес");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new JustForm();
            frm2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
