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
    public partial class StudyLoadAddForm : Form
    {
        public StudyLoadAddForm()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select id, (first_name+' '+last_name+' '+sur_name) from teacher";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select id, name from discipline";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select id, name from study_group";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<TeacherAddForm>();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? teacher = null;
            int? discipline = null;
            int? group = null;
            try
            {
                teacher = Convert.ToInt32((comboBox1.SelectedItem as IdentityItem)?.Id);
                discipline = Convert.ToInt32((comboBox2.SelectedItem as IdentityItem)?.Id);
                group = Convert.ToInt32((comboBox3.SelectedItem as IdentityItem)?.Id);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "insert into study_load (teacher_id, discipline_id, group_id)" +
                "values (" + $"{teacher},{discipline},{group}" + ");";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }

    public class IdentityItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public IdentityItem(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
