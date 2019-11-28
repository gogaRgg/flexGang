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
    public partial class JustForm : Form
    {
        public JustForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Товары>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm2 = new Salleraddform();
            frm2.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new Продавцы();
            frm2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm2 = new Склад();
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form frm2 = new Скидки1();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm2 = new Продажи();
            frm2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm2 = new Товар_на_складе();
            frm2.Show();
            this.Hide();
        }

        private void JustForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }

        private void JustForm_Load(object sender, EventArgs e)
        {

        }
    }
}
