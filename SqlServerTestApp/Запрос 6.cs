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
    public partial class Запрос_6 : Form
    {
        public Запрос_6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"select [id_продажи], [Цена] - (select [Размер скидки] from [Скидки] where [Скидки].[id_скидки] = [Продажи].[id_скидки]) as [Стоимость_со_скидкой],[id_товара], [id_продавца]
            from [Товары]
            left join [Кулиминов].[dbo].[Продажи]
            on [Продажи].[id_tovara] = [Товары].[id_товара]
            where [Продажи].[id_tovara] in (select [id_товара] from [Товары])";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            FormExtentions.ClearAndAddColumnsInDataGridView(dataGridView1,"id_продажи", "Стоимость_со_скидкой", "id_товара", "id_продавца");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new QueryComplete();
            frm2.Show();
            this.Hide();
        }
    }
}
