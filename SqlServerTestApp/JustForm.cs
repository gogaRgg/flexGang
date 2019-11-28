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
            this.OpenNewForm<Salleraddform>();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Продавцы>();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.OpenNewForm<Form1>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Склад>();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.OpenNewForm<Скидки1>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Продажи>();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Товар_на_складе>();
        }

        private void JustForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }

        private void JustForm_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Товар_в_продаже>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Товары_у_продавца>();
        }
    }
}
