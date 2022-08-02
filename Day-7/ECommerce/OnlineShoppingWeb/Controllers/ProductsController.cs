using OnlineShoppingWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace OnlineShoppingWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

       /* public ActionResult List()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product({Id = 34,
                Title = "Gerbera",
                Description = "Wedding Flower",
                UnitPrice = 12,
                Quantity = 34)})


            {

               
                Id = 34,
                Title = "Gerbera",
                Description = "Wedding Flower",
                UnitPrice = 12,
                Quantity = 34
            };
            return Json(obj,JsonRequestBehavior.AllowGet);
        }*/
    }
}