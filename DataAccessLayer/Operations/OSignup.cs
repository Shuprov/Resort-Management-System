using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OSignup
    {
        public int Insert(ESignup eSignup)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Signup values('" + eSignup.Name + "','" + eSignup.Email + "','" + eSignup.Password + "','" + eSignup.Phone + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
