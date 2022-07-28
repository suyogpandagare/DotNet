using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    //Request handler
    //Response Generation
    public class ProductsController
    {
        ProductManager mgr = new ProductManager();
        ProductManager pm = null;
        public ProductsController(ProductManager pm)
        {
            this.mgr = pm;
            this.mgr.Initialize();
        }

        //there are action methods
        //like index page in book has all info hence Indexmethod will give all products
        public List<Product> Index()
        {
            return mgr.GetAll();
        }

        public Product Details(int id)
        {
            return mgr.GetById(id);
        }

        public bool Post(Product product)
        {
            return mgr.Insert(product);
        }

        public bool Put(Product product)
        {
            return mgr.Update(product);
        }

        public bool Delete(int id)
        {
            return mgr.Delete(id);
        }
    }
}
