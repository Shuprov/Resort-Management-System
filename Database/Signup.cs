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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtPassword.Text !="" && txtPhone.Text !="")
            { 
            ESignup eSignup = new ESignup();
            OSignup oSignup = new OSignup();
            eSignup.Name = txtName.Text;
            eSignup.Email = txtEmail.Text;
            eSignup.Password = txtPassword.Text;
            eSignup.Phone = txtPhone.Text;
            int flag = oSignup.Insert(eSignup);
            if (flag > 0)
            {
                MessageBox.Show("Signup successful!");
            }
            else
            {
                MessageBox.Show("Signup Failed!");
            }
            }
            else
            {
                MessageBox.Show("Please fill the box", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter only alphabet";
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Characters must be lowercase and contain @";
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Password must be minimum 8 characters";
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtPhone_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter only numbers and must be 11 characters";
        }

        private void txtPhone_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
