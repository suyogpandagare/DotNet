using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipRolesMgmt
{
    public class Person
    {
        //For Auto properties compiler will add private member as well as getter setter method
        //All Autoproperties start with uppercase
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Default se Parameterised call ho ra this is constructor chaining
        public Person() : this("Suyog","Pandagare")
        {
          
        }

        //Constructor Overloading
        public Person(string fName,string lName)
        {
            //this. is implicit self reference
            this.Id = Guid.NewGuid().ToString();
            this.FirstName= fName;
            this.LastName= lName;
        }

        //Method Overriding
        public override string ToString()
        {
            //return this.Id+" "+this.FirstName+" "+this.LastName;
            string str = string.Empty;
            str = string.Format("Id={0}, FirstName={1}, LastName={2}", Id, FirstName, LastName);
            return str;     
        }
    }
}
