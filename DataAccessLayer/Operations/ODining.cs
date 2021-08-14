using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class ODining
    {
        public int Insert(EDining eDining)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Dining values('" + eDining.Id + "','" + eDining.Fooditem + "','" + eDining.Price + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Dining", connection);
            connection.Close();
            return sqlDataAdapter;
        }

        public int Update(EDining eDining)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=SHUPROV\SQLEXPRESS;Initial Catalog=DBconnection;Integrated Security=True");
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Dining set  Fooditem='" + eDining.Fooditem + "',Price='" + eDining.Price + "' where Id='" + eDining.Id + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(EDining eDining)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Dining where Id='" + eDining.Id + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
