using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
namespace ShoppingConsole
{
    internal class Program
    {
        //Design Pattern : MVC
        static void Main(string[] args)
        {
            //Business Logic
            ProductManager productManager = new ProductManager();
           
            //Controller
            ProductsController pc = new ProductsController(productManager);  //constructor dependency injection

            List<Product> products = pc.Index();  //Model

            //View
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************Product Catalogue********************");
            foreach (Product product in products)
            {
                Console.WriteLine("ID :"+product.Id);
                Console.WriteLine("Title: "+product.Title);
                Console.WriteLine("Description :"+product.Description);
                Console.WriteLine("Price :"+product.Price);
                Console.WriteLine("Quantity :"+product.Quantity);
                Console.WriteLine("**********************************************");
            }


            Console.ReadLine();
        }
    }
}
