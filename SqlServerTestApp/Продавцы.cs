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
    public partial class Продавцы : Form
    {
        public Продавцы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1,tb2 = null;
             tb1 = textBox1.Text;
             tb2 = textBox2.Text;
            try
            {
               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            string query = "INSERT INTO dbo.Продавец (ФИО,[название магазина]) VALUES ('" + tb1 + "', '" + tb2 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");
           }
            private void button2_Click(object sender, EventArgs e)
           {
            string query = @"SELECT
            [ФИО]
            ,[название магазина]
            FROM [dbo].[Продавец]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "ФИО", "название магазина");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new JustForm();
            frm2.Show();
            this.Hide();
        }
        private void Продавцы_Load(object sender, EventArgs e)
        {

        }
    }
}
