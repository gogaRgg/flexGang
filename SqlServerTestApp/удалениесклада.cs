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
    public partial class удалениесклада : Form
    {
        public удалениесклада()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
            string query = "Delete from dbo.Склад where [id_склада]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("done");
                comboBox1.SelectedItem = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
[id_склада],
            [адрес]
            
            FROM [dbo].[Склад]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1,"id_склада","адрес");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1]);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            string query = "select [id_склада],[адрес] from [dbo].[Склад]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void удалениесклада_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
