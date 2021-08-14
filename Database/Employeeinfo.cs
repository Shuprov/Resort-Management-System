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
    }
}
