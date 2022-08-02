using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventApp
{
    //I am just preparing code for our todays learning
    //This is the way we declare delegate
    //Delegate defined compliance, Rules
    public delegate void AccountOperation( double penalty);

    public  class Account
    {
        public event AccountOperation underBalance;
        public event AccountOperation overBalance;
        public double Balance { get; set; }
        public void Deposit(double amount) {
            Balance += amount;
            if(Balance > 250000)
            {
                overBalance(300);
            }          
        }
        public void Withdraw(double amount) {
            Balance -=amount;
            if (Balance <= 5000)
            {
                //trigger event
                //raise event
                underBalance(30000);
            }
        }
    }
}
