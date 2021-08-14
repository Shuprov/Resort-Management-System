using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class ORoom
    {
        public int Insert(ERoom eRoom)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Room values('" + eRoom.Roomid + "','" + eRoom.Roomtype + "','" + eRoom.Roomprice + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Room", connection);
            connection.Close();
            return sqlDataAdapter;
        }

        public int Update(ERoom eRoom)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=SHUPROV\SQLEXPRESS;Initial Catalog=DBconnection;Integrated Security=True");
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Room set  Roomtype='" + eRoom.Roomtype + "',Roomprice='" + eRoom.Roomprice + "' where Roomid='" + eRoom.Roomid + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(ERoom eRoom)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Room where Roomid='" + eRoom.Roomid + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
