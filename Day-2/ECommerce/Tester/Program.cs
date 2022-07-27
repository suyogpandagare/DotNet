using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
using Banking;
namespace Tester
{
    public static class Counter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is second entry point function");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt.ToString());
           
            Person p = new Person();
            Console.WriteLine(p);
          

            Account act = new Account(60000);
            act.Deposit(10000);
            double result = act.Balance;    //getter called
            Console.WriteLine(result);
           
            Console.ReadLine();
        }
    }
}
