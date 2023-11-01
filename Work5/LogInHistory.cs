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
    public partial class LogInHistory : Form
    {
        public LogInHistory()
        {
            InitializeComponent();
        }

        private void LogInHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("item_name", "ФИО");
            dataGridView1.Columns.Add("item_time", "Время");
            dataGridView1.Columns.Add("iem_cost", "Успешно?");

            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:28", "Да");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:27", "Нет");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:26", "Да");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:26", "Да");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:26", "Нет");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:25", "Да");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:24", "Нет");
            dataGridView1.Rows.Add("Квасов Арсений Александрович", "2023-10-31 01:24", "Да");
        }
    }
}
