using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if(email=="ravi.tambade@transflower.in" && password == "seed")
            {
                //State managment  using two ways
                //Client Side State Management
                // query string, cookies,  url rewriting, local storage, session storage
                //Server Side State Management
                // Application Variables, Session Variables, Cache
                // TempData
                this.Session["user"] = email;
                this.Response.Cookies.Add(new HttpCookie("token", email));
                return RedirectToAction("profile","customers");
            }
            return View();
        }
    }
}