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

        public void Update(Product pProduct)
        {


            using (supermarket mySupermarket = new supermarket())
            {

                Product productObj = mySupermarket.Products

                .Where(Product => Product.ProductId == pProduct.ProductId)
                .SingleOrDefault();

                if (productObj != null)
                {
                    productObj.Name = pProduct.Name;
                    productObj.Description = pProduct.Description;
                    productObj.Price = pProduct.Price;
                    productObj.Amount = productObj.Amount;


                    mySupermarket.SaveChanges();
                }
            }
        }

        public void Delete(int pId)
        {
            using (supermarket mySupermarket = new supermarket())
            {

                Product productDelete = mySupermarket.Products

               .Where(Product => Product.ProductId == pId)
               .SingleOrDefault();

                if (productDelete != null)
                {

                    mySupermarket.Products.Remove(productDelete);
                    mySupermarket.SaveChanges();

                }

            }

        }
    }
}
