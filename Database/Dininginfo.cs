using DataAccessLayer.Entities;
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
    public partial class Dininginfo : Form
    {
        public Dininginfo()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EDining eDining = new EDining();
            ODining oDining = new ODining();
            eDining.Id = txtId.Text;
            eDining.Fooditem = txtFood.Text;
            eDining.Price = txtPrice.Text;

            int flag = oDining.Insert(eDining);
            if (flag > 0)
            {
                MessageBox.Show("Inserted successfully");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ODining oDining = new ODining();
            SqlDataAdapter sqlDataAdapter = oDining.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EDining eDining = new EDining();
            ODining oDining= new ODining();
            eDining.Id = txtId.Text;
            eDining.Fooditem = txtFood.Text;
            eDining.Price = txtPrice.Text;
            int flag = oDining.Update(eDining);
            if (flag > 0)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EDining eDining = new EDining();
            ODining oDining = new ODining();
            eDining.Id = txtId.Text;
            eDining.Fooditem = txtFood.Text;
            eDining.Price = txtPrice.Text;

            int flag = oDining.Delete(eDining);
            if (flag > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
            this.Hide();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void roomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Roominfo().Show();
            this.Hide();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Employeeinfo().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to view dining menu";
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnInsert_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to insert dining menu";
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update dining menu";
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete dining menu";
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
