using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace DataAccess
{
    public class DataCustomers
    {

        public List<Customer> SelectAll()
        {
            using (supermarket mySupermarket = new supermarket())
            {
                List<Customer> allCustomers = mySupermarket.Customers.ToList();

                return allCustomers;

            }

        }
        public Customer SelectById(int id)
        {

            using (supermarket mySupermarket = new supermarket())
            {

                Customer customerFromId = mySupermarket.Customers

                .Where(Customer => Customer.CustomerId == id)
                .SingleOrDefault();

                return customerFromId;
            }
        }

        public List<Customer> SelectByFrom(String Address)
        {

            using (supermarket mySupermarket = new supermarket())
            {
                List<Customer> customerList = mySupermarket.Customers

                .Where(Customer => Customer.Address.Contains(Address))
                .ToList();

                return customerList;

            }
        }

        public void Insert(Customer pCustomer)
        {


            using (supermarket mySupermarket = new supermarket())
            {
                mySupermarket.Customers.Add(pCustomer);
                mySupermarket.SaveChanges();

            }
        }

        public void Update(Customer pCustomer)
        {


            using (supermarket mySupermarket = new supermarket())
            {

                Customer customerObj = mySupermarket.Customers

                .Where(Customer => Customer.CustomerId == pCustomer.CustomerId)
                .SingleOrDefault();

                if (customerObj != null)
                {
                    customerObj.Address = pCustomer.Address;
                    customerObj.FistName = pCustomer.FistName;
                    customerObj.LastName = pCustomer.LastName;
                    customerObj.Telephone = pCustomer.Telephone;

                    mySupermarket.SaveChanges();
                }
            }
        }

        public void Delete(int pId)
        {
            using (supermarket mySupermarket = new supermarket())
            {

                Customer customerDelete = mySupermarket.Customers

               .Where(Customer => Customer.CustomerId == pId)
               .SingleOrDefault();

                if (customerDelete != null)
                {

                    mySupermarket.Customers.Remove(customerDelete);
                    mySupermarket.SaveChanges();

                }

            }


        }

    }

}

