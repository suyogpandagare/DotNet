using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Shape s = new Line();
            //Shape shape = new Shape();
            Line l = Shape as Line;
            
            //new way using property initailizer syntax
            l.StartPoint = new Point { X = 12, Y = 45 };
            l.EndPoint = new Point { X = 120, Y = 405 };
            l.Draw();*/

            //public methods directly available
            Profile userProfile = new Profile();

            //Provider instance has been invoked through interface methods
            userProfile.TrackOrder();
            userProfile.CancelOrder();

            //private methods should be called with FullyQualified Name
            ICustomerDetails icustDetails = userProfile;
            icustDetails.ShowDetails();

            IOrderDetails orderDetails = userProfile;
            orderDetails.ShowDetails();

          

            Console.ReadLine();

        }
    }
}
