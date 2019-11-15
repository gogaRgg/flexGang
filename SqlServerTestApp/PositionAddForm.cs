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
    public partial class PositionAddForm : Form
    {
        public PositionAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string query = "INSERT INTO dbo.Товары (название, Цена) VALUES ('" + tb1 + "', '" + tb2 + "')";
            int? count = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено " + count + "строк");
        
        }

        private void PositionAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
