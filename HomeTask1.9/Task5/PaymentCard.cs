using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask19.Task5
{
    public class PaymentCard
    {
        public double Balance { get; private set; }

        public PaymentCard(double balance)
        {
            this.Balance = balance;
        }

        public void AddMoney(double amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
            }
        }

        public bool TakeMoney(double amount)
        {
            if (amount <= this.Balance)
            {
                this.Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Card balance: {this.Balance:0.00} EUR";
        }
    }
}
