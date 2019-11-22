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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<DBConnectionForm>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.OpenNewForm<DBConnectionForm>();
        }

       

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm2 = new RequestData();
            frm2.Show();
            this.Hide();
        }

      

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form1337();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа представляет собой тестировачный проект связанный с базой данных,и присдует цель ознакомления с подключением Бд к c# " +
                "Выполнили Кулёв Игорь и Аминов Владислав ");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form frm2 = new QueryComplete();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Form frm2 = new JustForm();
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm2 = new Удаление();
            frm2.Show();
            this.Hide();
        }
    }
}
