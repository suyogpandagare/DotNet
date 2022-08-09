using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecureWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}