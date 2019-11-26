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
    public partial class Удаление : Form
    {
        public Удаление()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new удалениетовара();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm2 = new Удалениеклиента();
            frm2.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new удалениепродавца();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm2 = new удалениескидки();
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm2 = new удалениесклада();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm2 = new Продажи();
            frm2.Show();
            this.Hide();
        }
    }
}
