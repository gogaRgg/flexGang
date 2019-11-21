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
    public partial class Salleraddform : Form 

    {
        
        public Salleraddform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            string tb5 = textBox5.Text;
            string tb6 = textBox6.Text;
            string query = "INSERT INTO dbo.Клиенты (Фамилия, Имя,Отчество,Телефон,Email,Постоянный) VALUES ('" + tb1 + "', '" + tb2 + "','" + tb3 + "','" + tb4 + "','" + tb5 + "','" + tb6+ "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1,"Фамилия","Имя","Отчество","Телефон","Email","Постоянный");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void Salleraddform_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form frm2 = new JustForm();
            frm2.Show();
            this.Hide();
        }
    }
}
