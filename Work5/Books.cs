using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work5
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("item_id", "ID");
            dataGridView1.Columns.Add("item_author", "Автор");
            dataGridView1.Columns.Add("item_name", "Название");
            dataGridView1.Columns.Add("item_publisher", "Издательство");
            dataGridView1.Columns.Add("item_date", "Год издания");
            dataGridView1.Columns.Add("item_amount", "Кол-во экземпляров");

            dataGridView1.Rows.Add("101", "Александр Пушкин", "Евгений Онегин", "Издательство А", "2009", "50");
            dataGridView1.Rows.Add("102", "Лев Толстой", "Война и мир", "Издательство В", "2008", "7");
            dataGridView1.Rows.Add("103", "Фёдор Достоевский", "Преступление и наказание", "Издательство А", "2008", "12");
            dataGridView1.Rows.Add("104", "Джордж Оруэлл", "1984", "Издательство А", "2008", "5");
            dataGridView1.Rows.Add("105", "Джейн Остин", "Гордость и предубеждение", "Издательство В", "2008", "8");

        }
    }
}
