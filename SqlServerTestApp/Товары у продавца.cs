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
    public partial class Товары_у_продавца : Form
    {
        public Товары_у_продавца()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<JustForm>();
        }

        private void Товары_у_продавца_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
