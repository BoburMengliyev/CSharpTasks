using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18
{
    public class Account
    {
        private double Balance = 0;
        public Account(double balance) 
        {
            this.Balance = balance;
        }
        public void Deposit(double amount) 
        {
            this.Balance += amount;
        }
        public void Withdraw(double amount) 
        {
            this.Balance -= amount;
        }

        public override string ToString() 
        {
            return Balance.ToString();
        }
    }
}