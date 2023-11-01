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
    public partial class Readers : Form
    {
        public Readers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Readers_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("item_id", "ID");
            dataGridView1.Columns.Add("item_author", "ФИО");
            dataGridView1.Columns.Add("item_name", "Номер телефона");
            dataGridView1.Columns.Add("item_publisher", "Пароль");

            dataGridView1.Rows.Add("1", "Квасов Арсений Александрович", "+7 (999) 520-50-47", "123!");
            dataGridView1.Rows.Add("2", "Пилецкая Надежда Андреевна", "+7 (999) 247-25-73", "123!");
            dataGridView1.Rows.Add("3", "Куцуркин Мзаут Витальевич", "+7 (912) 911-8555", "123!");
        }
    }
}
