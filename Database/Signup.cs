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
    }
}
