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

        private void button2_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<StudyLoadAddForm>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.OpenNewForm<TeacherAddForm>();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "select (teacher.first_name+' '+teacher.last_name+' '+teacher.sur_name), discipline.name, study_group.name " +
                "from study_load , teacher, discipline, study_group " +
                "where teacher.id = study_load.teacher_id and " +
                "study_group.id = study_load.group_id and " +
                "discipline.id = study_load.discipline_id;"
                ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Teacher", "Teacher");
            dataGridView1.Columns.Add("Discipline", "Discipline");
            dataGridView1.Columns.Add("Group", "Group");
            foreach(var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
            dataGridView1.Refresh();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form  frm2 = new PositionAddForm();
            frm2.Show();
            this.Hide();
        }
    }
}
