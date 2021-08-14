using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EEmployee
    {
        private string employeeid;
        private string name;
        private string email;
        private string phone;
        private string occupation;
        private string salary;

        public string Employeeid
        {
            set;
            get;
        }
        public string Name
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public string Phone
        {
            set;
            get;
        }
        public string Occupation
        {
            set;
            get;
        }
        public string Salary
        {
            set;
            get;
        }
    }
}
