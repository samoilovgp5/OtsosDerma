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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            DBConnection.GetGender();
            comboBox1.DataSource = DBConnection.dtGender;
            comboBox1.ValueMember = "Name";
            comboBox1.DisplayMember = "Code";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
