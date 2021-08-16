using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ESignup
    {
        private string name;
        private string email;
        private string password;
        private string phone;

       
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
        
    }
}
