using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (this.Session["user"]!=null)
            {
                return View();
            }
            else
            {
              
                return RedirectToAction("Login", "Account");
            }
       
        }

        public ActionResult Aboutus()
        {
            //Send data from action method to View

            string companyName = "Trasflower Learning Pvt. Ltd.";
            string founder = "Ravi Tambade";
            string coFounder = "Shubhangi Tambade";
            string vision = "Doing ordinary things extra ordinarily...";

            this.ViewBag.companyName = companyName;
            this.ViewBag.founder = founder;
            this.ViewBag.coFounder = coFounder;
            this.ViewBag.vision = vision;   

            return View();
        }


        public  ActionResult Contactus()
        {
            string email = "ravi.tambade@transflower.in";
            string contactNumber = "9881735801";
            string location = "Walvekar Nagar, Pune Satra Road, Pune 411009";

            this.ViewData["email"] = email;
            this.ViewData["contactNumber"] = contactNumber;
            this.ViewData["location"] = location;
            return View();
        }


        public ActionResult Services()
        {
            List<string> services=new List<string>();
            services.Add("DevCamps");
            services.Add("OnlineTrainings");
            services.Add("ActsTrainings");
            services.Add("CorporateTrainings");
            //like session managment
            this.TempData["services"] = services;
            return View();
        }

        public ActionResult Career()
        {
            List<string> services = this.TempData["services"] as List<string>;
            this.ViewData["ourservices"]=services;
            return View();
        }





    }
}