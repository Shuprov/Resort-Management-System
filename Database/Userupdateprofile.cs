using DataAccessLayer.Entities;
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
    public partial class Userupdateprofile : Form
    {
        public Userupdateprofile()
        {
            InitializeComponent();
        }

        /*private void btnViewprofile_Click(object sender, EventArgs e)
        {
            EUserprofileupdate eUserprofileupdate = new EUserprofileupdate();
            OUserviewprofile oUserviewprofile = new OUserviewprofile();
            SqlDataAdapter sqlDataAdapter = oUserviewprofile.Show(eUserprofileupdate);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EUserprofileupdate eUserprofileupdate = new EUserprofileupdate();
            OUserviewprofile oUserviewprofile = new OUserviewprofile();
            eUserprofileupdate.Name = txtName.Text;
            eUserprofileupdate.Email = txtEmail.Text;
            eUserprofileupdate.Password = txtPassword.Text;
            eUserprofileupdate.Phone = txtPhone.Text;
            
            int flag = oUserviewprofile.Update(eUserprofileupdate);
            if (flag > 0)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void roomReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Userhome().Show();
            this.Hide();
        }

        private void foodMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Userfood().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
