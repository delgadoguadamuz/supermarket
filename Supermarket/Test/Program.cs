using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (supermarket mySupermarket = new supermarket())
            {
                Customer fistCustomer = new Customer();

                fistCustomer.FistName = "Juan";
                fistCustomer.LastName = "Perez";
                fistCustomer.Address = "Alajuela";
                fistCustomer.Telephone = 111111;

                mySupermarket.Customers.Add(fistCustomer);
                mySupermarket.SaveChanges();


            }
            Console.WriteLine("Completed");
            Console.ReadKey();
        }
    }
}
