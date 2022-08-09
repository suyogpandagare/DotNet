using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AuthService
{
     public class Service1 : IService1
    {
        public User GetUserDetails(string username)
        {
            User user = new User(); 
            switch (username)
            {
                case "ravi":
                    user.FirstName = "Ravi";
                    user.LastName = "Tambade";
                    user.Password = "123";
                    break;

                case "sameer":
                    user.FirstName = "Sameer";
                    user.LastName = "Patil";
                    user.Password = "654";
                    break;
            }

            return user;
             
        }

        public bool Register(string username, string password)
        {
            bool result = false;

            //set data to backend using entity framework or ado.net connected or disconnect
            return result;

            
        }

        public bool Validate(string username, string password)
        {
            bool status = false;

            if(username =="ravitambade" && password == "ibm")
            {
                status = true;
            }
            return status;
             
        }
    }
}
