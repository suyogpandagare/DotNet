using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    internal class Controller
    {

        //Callback functions
        //Event Receivers
        //action handlers
        //event handlers

        //Callback Function
        public void BlockAccount(double amount)
        {

            Console.WriteLine("your account has been blocked temporarily");
        }

        public void SendEmail(double amount)
        {
            Console.WriteLine("Email has been sent to registered  email address");

        }

        public void SendSMS(double amount)
        {
            Console.WriteLine("SMS has been sent to registered  mobile number");
        }

        public void DeductIncomeTax( double amount)
        {
            Console.WriteLine("Income Tax has been deducted from your Account");

        }
    }
}
