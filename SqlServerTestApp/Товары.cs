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
    public partial class Товары : Form
    {
        public Товары()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string query = "INSERT INTO dbo.Товары (название, Цена) VALUES ('" + tb1 + "', '" + tb2 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id_товара]
            ,[название]
            ,[Цена]
           
            FROM [dbo].[Товары]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1, "id_товара","название","Цена");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }

        }

        private void Товары_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.OpenNewForm<JustForm>();
        }

        private void Товары_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
