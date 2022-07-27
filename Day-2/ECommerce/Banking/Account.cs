using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account(double amount)
        {
            this.balance = amount;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;   
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
