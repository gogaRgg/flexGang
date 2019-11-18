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
    public partial class Form1337 : Form
    {
        public Form1337()
        {
            InitializeComponent();
        }

        private void Form1337_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}
