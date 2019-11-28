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

            this.OpenNewForm<Form1>();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.OpenNewForm<Изменениетовара>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Изменениеклиента>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<изменение_склада>();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Измемениепродавца>();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       

        private void Изменение_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
