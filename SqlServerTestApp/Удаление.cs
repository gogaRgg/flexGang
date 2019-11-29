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
            this.OpenNewForm<удалениетовара>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<Удалениеклиента>();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<удалениепродавца>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<удалениескидки>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<удалениесклада>();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Удаление_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
