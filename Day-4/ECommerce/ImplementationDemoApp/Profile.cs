using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationDemoApp
{
    //Explicit Interface Inheritance
    //Multiple interface Inheritance
    public class Profile : ICustomerDetails, IOrderDetails
    {
        public void CancelOrder()
        {
            Console.WriteLine("Requesting for Cancel Order ");
        }

        public void ChangePassword(string newPassword, string oldPassword, string loginName)
        {
            Console.WriteLine("Requesting for Changing old Password ");
        }

        public void TrackOrder()
        {
            Console.WriteLine("requesting for Track Order ");
        }

        //Fully Qualified name => because 2 methods with same names are present
        void ICustomerDetails.ShowDetails()
        {
            Console.WriteLine("Showing Customer Details");
        }
         void IOrderDetails.ShowDetails()
        {
            Console.WriteLine("Showing Order Details");

        }

    }
}
