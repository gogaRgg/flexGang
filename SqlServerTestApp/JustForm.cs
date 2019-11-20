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
            Form frm2 = new Товары();
            frm2.Show();
            this.Hide();
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
    }
}
