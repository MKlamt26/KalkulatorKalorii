using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MKKalkulator
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openShowForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ShowPanel.Controls.Add(childForm);
            ShowPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PodajDane_Click(object sender, EventArgs e)
        {
            openShowForm(new Form1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openShowForm(new Form4());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openShowForm(new Form6());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openShowForm(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openShowForm(new Form5());
        }
    }
}
