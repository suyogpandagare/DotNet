using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SecureWebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password, string ReturnUrl)
        {
            if(email=="suyogpandagare17@gmail.com" && password == "s123")
            {
                FormsAuthentication.SetAuthCookie(email, false);  
                return Redirect(ReturnUrl ?? Url.Action("Index", "Home"));
            }
            else
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("index", "home");

        }
    }
}