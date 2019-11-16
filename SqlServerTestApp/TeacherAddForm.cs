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
    public partial class TeacherAddForm : Form
    {
        public TeacherAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = null;
            string lName = null;
            string sName = null;
            int? wExp = null;
            int? pos = null;
            try
            {
                fName = textBox1.Text;
                lName = textBox2.Text;
                sName = textBox3.Text;
                wExp = Convert.ToInt32(textBox4.Text);
                var posResult = DBConnectionService.SendScalarQueryToSqlServer($"select id from position where name='{comboBox1.Text}'");
                if (posResult == null)
                {
                    throw new Exception("\"Position\" value is not correct");
                }
                else
                {
                    pos = Convert.ToInt32(posResult);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "insert into teacher (first_name, last_name, sur_name, degree_id, position_id, work_expirience)" +
                "values ("+$"'{fName}','{lName}','{sName}',null,{pos},{wExp}"+")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select name from position";
            string[] list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => row[0]).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void TeacherAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseForm();
        }
    }
}
