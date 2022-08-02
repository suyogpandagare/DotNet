using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnlineShoppingWeb.Models;
using OnlineShoppingWeb.DAL;

namespace OnlineShoppingWeb.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>();
        public ProductsController() {
             DataManager mgr = new DataManager();
             string filePath = @"d:/try/products.json";
            products = mgr.Load(filePath);
        }
        // GET: Products

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult List()
        { 
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Product foundProduct = products.Find((product) =>(product.Id ==id));
            return Json(foundProduct, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult Insert()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Insert(int productid, string title, string description, int unitprice, int quantity)
        {
          
            Product newProduct = new Product
            {
                Id = productid,
                Title = title,
                Description = description,
                UnitPrice = unitprice,
                Quantity = quantity,
                ImageUrl="/images/rose.jpg"
            };
            DataManager mgr = new DataManager();
            mgr.Insert(newProduct);
            return RedirectToAction("index");  //
        }

    }
}