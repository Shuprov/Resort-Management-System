using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void roomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Roominfo().Show();
            this.Hide();
        }

        private void staffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Employeeinfo().Show();
            this.Hide();
        }

        private void foodInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dininginfo().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
