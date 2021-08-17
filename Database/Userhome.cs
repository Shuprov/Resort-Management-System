using DataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Userhome : Form
    {
        public Userhome()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OUserhome oUserhome = new OUserhome();
            SqlDataAdapter sqlDataAdapter = oUserhome.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void foodMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Userfood().Show();
            this.Hide();
           
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Userupdateprofile().Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to view available rooms";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
