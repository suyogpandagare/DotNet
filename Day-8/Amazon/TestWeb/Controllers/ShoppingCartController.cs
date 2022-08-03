using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestWeb.Models;
namespace TestWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShopppingCart
        public ActionResult Index()
        {
            Cart theCart = (Cart)this.Session["cart"];
            this.ViewData["theCart"] = theCart;
            return View();
        }

        public ActionResult AddtoCart( int id)
        {
            Item item = new Item {
                Product = id,
                Quantity = 1 };
            Cart theCart = (Cart)this.Session["cart"];
            theCart.Items.Add(item);
            return RedirectToAction("index");
        }

        public ActionResult RemoveFromCart(int id)
        {
            Cart theCart = (Cart)this.Session["cart"];
            Item foundItem = theCart.Items.Find((item) => (item.Product == id));
            theCart.Items.Remove(foundItem);
            return RedirectToAction("index");
        }
    }
}