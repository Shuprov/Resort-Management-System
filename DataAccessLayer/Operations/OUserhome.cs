using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OUserhome
    {
        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = SHUPROV\SQLEXPRESS; Initial Catalog =Resort Management System; Integrated Security = True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Room", connection);
            connection.Close();
            return sqlDataAdapter;
        }
    }
}
