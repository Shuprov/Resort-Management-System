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
    public partial class Employeeinfo : Form
    {
        public Employeeinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();
            eEmployee.Employeeid = txtId.Text;
            eEmployee.Name = txtName.Text;
            eEmployee.Email = txtEmail.Text;
            eEmployee.Phone = txtPhone.Text;
            eEmployee.Occupation = txtOccupation.Text;
            eEmployee.Salary = txtSalary.Text;
            int flag = oEmployee.Insert(eEmployee);
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
            OEmployee oEmployee = new OEmployee();
            SqlDataAdapter sqlDataAdapter = oEmployee.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();
            eEmployee.Employeeid = txtId.Text;
            eEmployee.Name = txtName.Text;
            eEmployee.Email = txtEmail.Text;
            eEmployee.Phone = txtPhone.Text;
            eEmployee.Occupation = txtOccupation.Text;
            eEmployee.Salary = txtSalary.Text;
            int flag = oEmployee.Update(eEmployee);
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
            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();
            eEmployee.Employeeid = txtId.Text;
            eEmployee.Name = txtName.Text;
            eEmployee.Email = txtEmail.Text;
            eEmployee.Phone = txtPhone.Text;
            eEmployee.Occupation = txtOccupation.Text;
            eEmployee.Salary = txtSalary.Text;
            int flag = oEmployee.Delete(eEmployee);
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

        private void diningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dininginfo().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to view employee data";
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnInsert_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to insert employee data";
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update employee data";
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete employee data";
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
