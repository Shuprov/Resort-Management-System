using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EDining
    {
        private string id;
        private string fooditem;
        private string price;

        public string Id
        {
            set;
            get;
        }
        public string Fooditem
        {
            set;
            get;
        }
        public string Price
        {
            set;
            get;
        }
    }
}
