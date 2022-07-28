using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
namespace MembershipRolesMgmt
{
    //Multi level Inheritance
    public sealed class Customer : User
    {
        //Specialized Attributes
        public Address ResidentialAddress { get; set; }  
        public Address deliveryAddress { get; set; }

        public Customer(string fNmae,string lName,string loginName,
            string password,Address resAddress,Address delAddress): base(fNmae,lName,loginName,password)
        {
            this.ResidentialAddress = resAddress;
            this.deliveryAddress = delAddress;
            
        }
        public override string ToString()
        {
            string str = string.Empty;
            str = string.Format("{0} , Residential Address={1} , Delivery Address={2}", base.ToString(), ResidentialAddress, deliveryAddress);
            return str;
        }
    }
}
