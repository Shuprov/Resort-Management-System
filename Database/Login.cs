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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                SqlConnection c = new SqlConnection(@"Data Source=SHUPROV\SQLEXPRESS;Initial Catalog=Resort Management System;Integrated Security=True");
                string qls1 = "select * from Admin where Email = @Email and Password = @Password";
                string qls2 = "select * from Customer where Email = @Email and Password = @Password";

                SqlCommand com1 = new SqlCommand(qls1, c);
                SqlCommand com2 = new SqlCommand(qls2, c);
                com1.Parameters.AddWithValue("@Email", txtEmail.Text);
                com2.Parameters.AddWithValue("@Email", txtEmail.Text);
                com1.Parameters.AddWithValue("@Password", txtPassword.Text);
                com2.Parameters.AddWithValue("@Password", txtPassword.Text);

                //com1.Parameters.AddWithValue("@Type1", radiobtnAdmin.Text);
                //com2.Parameters.AddWithValue("@Type1", radiobtnAdmin.Text);
                //com1.Parameters.AddWithValue("@Type2", radiobtnUser.Text);
                //com2.Parameters.AddWithValue("@Type2", radiobtnUser.Text);
                c.Open();
                SqlDataReader dr1 = com1.ExecuteReader();
                if (dr1.HasRows == true)
                {
                    //MessageBox.Show("Admin Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Homepage().Show();
                    this.Hide();
                }
                /*else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                c.Close();
                c.Open();
                SqlDataReader dr2 = com2.ExecuteReader();

                if (dr2.HasRows == true)
                {
                    //MessageBox.Show("User Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Userhome().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c.Close();
            }
            else
            {
                MessageBox.Show("Please fill the box", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }
    }
    }

    

