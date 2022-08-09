using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.IService1 service1 = new ServiceReference1.Service1Client();
            Console.WriteLine("Enter user name");
            string username=Console.ReadLine();

            Console.WriteLine("Enter your  Password");
            string password = Console.ReadLine();
            bool status=service1.Validate(username, password);
            if(status)
            {
                Console.WriteLine("Welcome to dotnet");
            }
            else
            {
                Console.WriteLine("Invalid User , Please try again...");
            }

            Console.ReadLine();
        }
    }
}
