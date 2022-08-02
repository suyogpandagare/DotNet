using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Applying Event Delegation Model

            Account acct = new Account();
            Controller controller = new Controller();
            //Register function    
            //Route Mapping
            //we creating delegate instance and keeping them chainned
            //Chaining is a mechanim for attaching more than one event handlers

            acct.underBalance += new AccountOperation(controller.BlockAccount);
            acct.underBalance += new AccountOperation(controller.SendEmail);
            acct.underBalance += new AccountOperation(controller.SendSMS);

            acct.overBalance+=new AccountOperation(controller.DeductIncomeTax);
 
            acct.Balance = 56000;
            acct.Withdraw(5400);

           // acct.Deposit(300000);

            Console.WriteLine(acct.Balance);
            Console.ReadLine();

        }
    }
}
