using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationDemoApp
{
    //Interface is used to define Contract

    //interface enforces all methods to be implemented 
    public interface ICustomerDetails
    {
        //there methods must be implemented by implementing class

        //Rules: Constraints has to be followed by implementing class

        //inside interface all methods are private

        //Scope increase kr sakte in subclasses
        void ShowDetails();

        void CancelOrder();

        void TrackOrder();

        void ChangePassword(string newPassword,string oldPassword,
            string loginName);
    }
}
