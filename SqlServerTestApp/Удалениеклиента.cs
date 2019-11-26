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
            int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
            string query = "Delete from dbo.Клиенты where [id_клиента]="+id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("done");
                comboBox1.SelectedItem = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            string query = "select [id_клиента],[Фамилия]+' '+[Имя]+' '+[Отчество] from [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new Удаление();
            frm2.Show();
            this.Hide();
        }
    }
}
