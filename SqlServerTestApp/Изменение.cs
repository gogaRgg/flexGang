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
    public partial class Изменение : Form
    {
        public Изменение()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form frm2 = new Изменениетовара();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Изменениеклиента();
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm2 = new изменение_склада();
            frm2.Show();
            this.Hide();

        }
    }
}
