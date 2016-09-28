using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace DataAccess
{
    class DataProducts
    {
        public List<Product> SelectAll()
        {
            using (supermarket mySupermarket = new supermarket())
            {
                List<Product> allProducts = mySupermarket.Products.ToList();

                return allProducts;

            }

        }


        public Product SelectById(int id)
        {

            using (supermarket mySupermarket = new supermarket())
            {

                Product productsFromId = mySupermarket.Products

                .Where(Product => Product.ProductId == id)
                .SingleOrDefault();

                return productsFromId;
            }
        }

        public void Insert(Product pProduct)
        {


            using (supermarket mySupermarket = new supermarket())
            {
                mySupermarket.Products.Add(pProduct);
                mySupermarket.SaveChanges();

            }
        }


    }
}
