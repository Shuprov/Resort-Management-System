using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OEmployee
    {
        public int Insert(EEmployee eEmployee)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee values('" + eEmployee.Employeeid + "','" + eEmployee.Name + "','" + eEmployee.Email + "','" + eEmployee.Phone + "','" + eEmployee.Occupation + "','" + eEmployee.Salary + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employee", connection);
            connection.Close();
            return sqlDataAdapter;
        }

        public int Update(EEmployee eEmployee)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=SHUPROV\SQLEXPRESS;Initial Catalog=DBconnection;Integrated Security=True");
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Employee set  Name='" + eEmployee.Name + "',Email='" + eEmployee.Email + "',Phone='" + eEmployee.Phone + "',Occupation='" + eEmployee.Occupation + "',Salary='" + eEmployee.Salary + "' where Employeeid='" + eEmployee.Employeeid + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(EEmployee eEmployee)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Employee where Employeeid='" + eEmployee.Employeeid + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
