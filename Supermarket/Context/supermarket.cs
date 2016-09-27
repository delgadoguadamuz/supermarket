using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class supermarket : DbContext
    {
        public supermarket() : base("name=Supermarket")
        {


        }

        public virtual DbSet<Customer> Customers { get; set; }
        
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

    }
}
