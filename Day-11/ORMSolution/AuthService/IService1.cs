using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AuthService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
   
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool Validate(string username, string password);

        [OperationContract]

        bool Register(string username, string password);


        [OperationContract]
        User GetUserDetails(string username);
    }


   
    [DataContract]
    public class User
    {
        [DataMember]
        public string  FirstName {get;set; }

        [DataMember]
        public string LastName {get; set;}
        
        [DataMember]
        public string Password { get; set; }

    }
}
