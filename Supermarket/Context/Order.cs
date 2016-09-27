using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
   public  class Order
    {

        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string FistName { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public List<Product> Products { get; set; }
    }
}
