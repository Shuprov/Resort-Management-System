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
    public partial class Roominfo : Form
    {
        public Roominfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ERoom eRoom = new ERoom();
            ORoom oRoom = new ORoom();
            eRoom.Roomid = txtId.Text;
            eRoom.Roomtype = txtType.Text;
            eRoom.Roomprice = txtPrice.Text;
            
            int flag = oRoom.Insert(eRoom);
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
            ORoom oRoom = new ORoom();
            SqlDataAdapter sqlDataAdapter = oRoom.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ERoom eRoom = new ERoom();
            ORoom oRoom = new ORoom();
            eRoom.Roomid = txtId.Text;
            eRoom.Roomtype = txtType.Text;
            eRoom.Roomprice = txtPrice.Text;
            int flag = oRoom.Update(eRoom);
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
            ERoom eRoom = new ERoom();
            ORoom oRoom = new ORoom();
            eRoom.Roomid = txtId.Text;
            eRoom.Roomtype = txtType.Text;
            eRoom.Roomprice = txtPrice.Text;

            int flag = oRoom.Delete(eRoom);
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

        private void diningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dininginfo().Show();
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
            toolStripStatusLabel1.Text = "Click to view room data";
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnInsert_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to insert room data";
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update room data";
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete room data";
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
