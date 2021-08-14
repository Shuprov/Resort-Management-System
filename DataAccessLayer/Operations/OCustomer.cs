using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OCustomer
    {
        public int Insert(ECustomer eCustomer)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values('"+eCustomer.Id+"','"+eCustomer.Name+"','"+eCustomer.Email+"','"+eCustomer.Password+ "','" + eCustomer.Phone + "','" + eCustomer.Roomid + "')", connection);
            int flag=cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Customer", connection);
            connection.Close();
            return sqlDataAdapter;
        }

        public int Update(ECustomer eCustomer)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=SHUPROV\SQLEXPRESS;Initial Catalog=DBconnection;Integrated Security=True");
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Customer set  Name='" + eCustomer.Name+"',Email='" + eCustomer.Email+"',Password='" + eCustomer.Password+ "',Phone='" + eCustomer.Phone + "',Roomid='" + eCustomer.Roomid + "' where Id='" + eCustomer.Id+"'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(ECustomer eCustomer)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where Id='"+eCustomer.Id+"'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
