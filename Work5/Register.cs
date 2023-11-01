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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar == true)
            {
                textBox3.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.closeEye;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.openEye;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox4.UseSystemPasswordChar == true)
            {
                textBox4.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.closeEye;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.openEye;
            }
        }
    }
}
