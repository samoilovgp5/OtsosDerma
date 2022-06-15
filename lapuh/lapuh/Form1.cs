using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapuh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBconnection.connect() == false)
            {
                if (MessageBox.Show("ПОШЕЛ НАХУЙ", "НАХУЙ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.OK)
                    MessageBox.Show("НОРМ");
            }
            DBconnection.getkal();
            dataGridView1.DataSource = DBconnection.sas;
            textBox2.Text = DBconnection.getcou().ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Послать нахуй чела?", "ТОЧНО?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBconnection.delkal(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                DBconnection.getkal();
                dataGridView1.DataSource = DBconnection.sas;
                textBox2.Text = DBconnection.getcou().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DBconnection.connect() == false)
            {
                if (MessageBox.Show("ПОШЕЛ НАХУЙ", "НАХУЙ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.OK)
                    MessageBox.Show("НОРМ");
            }
            DBconnection.getkal();
            dataGridView1.DataSource = DBconnection.sas;
            textBox2.Text = DBconnection.getcou().ToString();
        }
    }
}
