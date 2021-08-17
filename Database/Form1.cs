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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();
            eCustomer.Id = txtId.Text;
            eCustomer.Name = txtName.Text;
            eCustomer.Email = txtEmail.Text;
            eCustomer.Password = txtPassword.Text;
            eCustomer.Phone = txtPhone.Text;
            eCustomer.Roomid = txtRoom.Text;
            int flag =oCustomer.Insert(eCustomer);
            if(flag>0)
            {
                MessageBox.Show("Inserted successfully");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();
            eCustomer.Id = txtId.Text;
            eCustomer.Name = txtName.Text;
            eCustomer.Email = txtEmail.Text;
            eCustomer.Password = txtPassword.Text;
            eCustomer.Phone = txtPhone.Text;
            eCustomer.Roomid = txtRoom.Text;
            int flag = oCustomer.Delete(eCustomer);
            if (flag > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();
            eCustomer.Id = txtId.Text;
            eCustomer.Name = txtName.Text;
            eCustomer.Email = txtEmail.Text;
            eCustomer.Password = txtPassword.Text;
            eCustomer.Phone = txtPhone.Text;
            eCustomer.Roomid = txtRoom.Text;
            int flag = oCustomer.Update(eCustomer);
            if (flag > 0)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OCustomer oCustomer = new OCustomer();
            SqlDataAdapter sqlDataAdapter = oCustomer.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
            this.Hide();
        }

        private void roomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Roominfo().Show();
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
            toolStripStatusLabel1.Text = "Click to view customer data";
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnInsert_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to insert customer data";
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update customer data";
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete customer data";
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
