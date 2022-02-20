using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud1.Models
{
    public class Customer
    {
        public int id { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public Address Address { get; set; }


    }
} 
