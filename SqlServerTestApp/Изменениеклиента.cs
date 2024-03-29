﻿using System;
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
[id_клиента],
            [Фамилия]
            ,[Имя]
            ,[Отчество]
            ,[Телефон]
            ,[Email] 
            ,[Постоянный]
            FROM [dbo].[Клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1,"id_клиента","Фамилия", "Имя", "Отчество", "Телефон", "Email", "Постоянный");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            string mm =Convert.ToString(textBox1.Text);
            string nn = Convert.ToString(textBox2.Text); 
            string nmm = Convert.ToString(textBox3.Text); 
            string nmn = Convert.ToString(textBox4.Text); 
            string nnn = Convert.ToString(textBox5.Text); 
            string mmm = Convert.ToString(textBox6.Text); 
           try
            {
                int kkk = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = "update dbo.Клиенты SET Имя='" + mm + "',Фамилия='" + nn + "',Отчество='" + nmm + "',Телефон='" + nmn + "',Email ='" + nnn + "',Постоянный='" + mmm + "' where [id_клиента]='" + kkk + "'";
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
            Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Изменениеклиента_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
