using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGovna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connection())
            {
                MessageBox.Show("Ошибка при подключении к базе данных", "Ошибка", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            DBConnection.GetClient();
            dataGridView1.DataSource = DBConnection.dtClient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection.DeleteClient(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DBConnection.GetClient();
            dataGridView1.DataSource = DBConnection.dtClient;
        }
    }
}
