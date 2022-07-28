using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    //Responsibility is to perform CRUD operations
    public class ProductManager
    {
       private List<Product> products = new List<Product>();
        
        //Atomic Operations=>Atomicity all operations are independent 
        public Product GetById(int id)
        {
            #region basic style of searching product from list
            //this is basic style of iterating and searching product based on condition
            /*foreach (Product product in products)
            {
                if (product.Id == id)
                    return product;
            }*/
            #endregion


            return products.Find(x => x.Id == id);  // inline/arrow function
        }
        public bool Initialize()
        {
            bool status = false;
            Product product = new Product();
            product.Id = 1;
            product.Title = "Gerbera";
            product.Description = "weeding flower";
            product.Price = 12;
            product.Quantity = 4000;

            products.Add(product);

            product = new Product();
            product.Id = 2;
            product.Title = "Rose";
            product.Description = "Valentine flower";
            product.Price = 124;
            product.Quantity = 24000;

            products.Add(product);

            product = new Product();
            product.Id = 3;
            product.Title = "Jasmine";
            product.Description = "Smeling flower";
            product.Price = 1;
            product.Quantity = 54000;

            products.Add(product);

            product = new Product();
            product.Id = 4;
            product.Title = "Lily";
            product.Description = "Worship flower";
            product.Price = 16;
            product.Quantity = 75000;

            products.Add(product);

            status = true;  
            return status;


        }
        public bool Insert(Product product)
        {
            bool status = false;
            Product duplicateProduct = products.Find(x => x.Id == product.Id);
            if(duplicateProduct != null)
            {
                status = false;
            }
            else
            {
                this.products.Add(product);   //Add() is function of List
                status = true;
            }
            return status;
        }
        public List<Product> GetAll()
        {
            return products;
        }
    
        public bool Delete(int id)
        {
            products.Remove(products.Find(x => x.Id == id));  //Find() is method of List
            return true;
        }
    
        public bool Update(Product product)
        {
            bool status = false;
            Product foundProduct = products.Find(x => x.Id == product.Id);
            if(foundProduct != null)
            {
                products.Remove(foundProduct);
                products.Add(product);
                status = true;
            }
            return status;
        }

    }
}
