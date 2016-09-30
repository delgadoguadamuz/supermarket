using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace DataAccess
{
    class DataOrders
    {
        public List<Order> SelectAll()
        {
            using (supermarket mySupermarket = new supermarket())
            {
                List<Order> allOrders = mySupermarket.Orders.ToList();

                return allOrders;

            }

        }


        public Order SelectById(int id)
        {

            using (supermarket mySupermarket = new supermarket())
            {

                Order OrdersFromId = mySupermarket.Orders

                .Where(Order => Order.OrderId == id)
                .SingleOrDefault();

                return OrdersFromId;
            }
        }

        public void Insert(Order pOrder)
        {


            using (supermarket mySupermarket = new supermarket())
            {
                mySupermarket.Orders.Add(pOrder);
                mySupermarket.SaveChanges();

            }
        }

        public void Update(Order pOrder)
        {


            using (supermarket mySupermarket = new supermarket())
            {

                Order orderObj = mySupermarket.Orders

                .Where(Order => Order.OrderId == pOrder.OrderId)
                .SingleOrDefault();

                if (orderObj != null)
                {
                    orderObj.OrderDate = pOrder.OrderDate;
                   


                    mySupermarket.SaveChanges();
                }
            }
        }

        public void Delete(int pId)
        {
            using (supermarket mySupermarket = new supermarket())
            {

                Order orderDelete = mySupermarket.Orders

               .Where(Order => Order.OrderId == pId)
               .SingleOrDefault();

                if (orderDelete != null)
                {

                    mySupermarket.Orders.Remove(orderDelete);
                    mySupermarket.SaveChanges();

                }

            }

        }
    }
}

