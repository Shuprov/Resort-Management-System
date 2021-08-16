using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OUserviewprofile
    {
        public SqlDataAdapter Show(EUserprofileupdate eUserprofileupdate)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name,Email,Phone from Signup where Phone='" + eUserprofileupdate.Phone + "'", connection);
            connection.Close();
            return sqlDataAdapter;
        }
        public int Update(EUserprofileupdate eUserprofileupdate)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=SHUPROV\SQLEXPRESS;Initial Catalog=DBconnection;Integrated Security=True");
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Signup set  Name='" + eUserprofileupdate.Name + "',Email='" + eUserprofileupdate.Email + "',Password='" + eUserprofileupdate.Password + "' where Phone='" + eUserprofileupdate.Phone + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
