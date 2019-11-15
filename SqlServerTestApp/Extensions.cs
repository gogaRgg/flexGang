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
    }
}
