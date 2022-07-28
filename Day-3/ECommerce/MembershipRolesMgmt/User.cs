using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipRolesMgmt
{
    public class User : Person
    {
        public string LoginName { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
        public User(string fName,string lName,string loginName,string password)
            :base(fName,lName)
        {
            LoginName = fName;
            Password = lName;
        }
        public override string ToString()
        {
            string str = string.Empty;
            str = string.Format("{0} , LoginName={1} , Password={2}",base.ToString(),LoginName,Password);
            return str;
        }

    }
}
