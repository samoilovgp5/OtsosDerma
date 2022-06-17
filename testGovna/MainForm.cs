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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connection())
            {
                MessageBox.Show("Ошибка при подключении к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBConnection.GetClient();
            dataGridView1.DataSource = DBConnection.dtClient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этого клиента?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DBConnection.DeleteClient(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            DBConnection.GetClient();
            dataGridView1.DataSource = DBConnection.dtClient;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddClient adc = new AddClient();
            adc.ShowDialog();
        }
    }
}