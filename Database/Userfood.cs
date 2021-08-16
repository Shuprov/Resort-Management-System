using DataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Userfood : Form
    {
        public Userfood()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void roomBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Userhome().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OUserfood oUserfood = new OUserfood();
            SqlDataAdapter sqlDataAdapter = oUserfood.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Userupdateprofile().Show();
            this.Hide();
        }
    }
}
