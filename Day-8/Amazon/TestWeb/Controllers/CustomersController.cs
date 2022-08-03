using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Profile()
        {
            return View();
        }


        public ActionResult PersonalInformation()
        {
            return View();
        }
    }
}