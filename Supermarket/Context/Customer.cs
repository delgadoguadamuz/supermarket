using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Context
{
   public class Customer
    {

        public int CustomerId { get; set; }

        public string FistName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int Telephone { get; set; }

        public List<Order> Orders { get; set; }

    }
}
