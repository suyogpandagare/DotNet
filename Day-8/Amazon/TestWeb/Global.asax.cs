using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using TestWeb.Models;

namespace TestWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {

        //Application Life Cycle Functions

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            Cart theCart = new Cart();
            theCart.Items.Add(new Item { Product = 99, Quantity = 2 });
            theCart.Items.Add(new Item { Product = 98, Quantity = 1 });
            theCart.Items.Add(new Item { Product = 77, Quantity = 2 });
            this.Session["cart"] = theCart;
            this.Session["user"] = "";
        }


        protected void Session_End()
        {
            this.Session.Clear();

        }


        protected void Application_End()
        {

        }

        protected void Application_Error()
        {

        }
    }
}