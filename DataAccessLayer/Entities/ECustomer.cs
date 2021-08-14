using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ECustomer
    {
        private string id;
        private string name;
        private string email;
        private string password;
        private string phone;
        private string roomid;

        public string Id
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
        public string Password
        {
            set;
            get;
        }
        public string Phone
        {
            set;
            get;
        }
        public string Roomid
        {
            set;
            get;
        }
    }
}
