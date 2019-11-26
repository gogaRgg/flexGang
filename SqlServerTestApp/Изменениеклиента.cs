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
    public partial class Изменениеклиента : Form
    {
        public Изменениеклиента()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string mn = null;
            string nm = null;
            string nmm = null;
            string nmn = null;
            string nnn = null;
            string mmm = null;
            try
            {
                mn = textBox1.Text;
                nm = textBox2.Text;
                nmm = textBox3.Text;
                nmn = textBox4.Text;
                nnn = textBox5.Text;
                mmm = textBox6.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Клиенты SET Имя='" + mn + "',Фамилия='" + nm + "',Отчество='" + nmm + "',Телефон='" + nmn + "',Email ='" + nnn + "',Постоянный='" + mmm + "' where id_клиента='" + n + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
