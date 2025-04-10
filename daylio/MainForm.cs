using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daylio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DiaryField.Text = "Добавьте запись...";
            DiaryField.ForeColor = Color.Gray;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DiaryField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DiaryField_Enter(object sender, EventArgs e)
        {
            if (DiaryField.Text == "Добавьте запись...")
            {
                DiaryField.Text = "";
                DiaryField.ForeColor = Color.Black;
            }
        }

        private void DiaryField_Leave(object sender, EventArgs e)
        {
            if (DiaryField.Text == "")
            {
                DiaryField.Text = "Добавьте запись...";
                DiaryField.ForeColor = Color.Gray;
            }

        }
    }
}
