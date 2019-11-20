using System.Windows.Forms;

namespace SqlServerTestApp
{
    public static class FormExtentions
    {
        public static void OpenNewForm<IForm>(this Form thisForm)
            where IForm : Form, new()
        {
            thisForm.Enabled = false;
            new IForm() { Owner = thisForm }.Show();
        }

        public static void CloseForm(this Form thisForm)
        {
            if (thisForm.Owner != null)
            {
                thisForm.Owner.Enabled = true;
            }
        }

        public static void ClearAndAddColumnsInDataGridView(DataGridView dataGrid, params string[] str)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            foreach (string s in str)
            {
                dataGrid.Columns.Add(s, s);
            }
        }

        public static void ClearAndAddColumnsInDataGridView(DataGridView dataGrid, string str)
        {
            ClearAndAddColumnsInDataGridView(dataGrid, new string[] { str });
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
