using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask19.Task5
{
    public class PaymentTerminal
    {
        public double Money { get; private set; }
        public int LunchSold { get; private set; }
        public int CoffeeSold { get; private set; }

        private const double LunchPrice = 10.0;
        private const double CoffeePrice = 2.5;

        public PaymentTerminal()
        {
            this.Money = 1000.0;
        }

        public bool BuyLunchWithCash(double cashGiven)
        {
            if (cashGiven >= LunchPrice)
            {
                this.Money += LunchPrice;
                this.LunchSold++;
                return true;
            }
            return false;
        }

        public bool BuyCoffeeWithCash(double cashGiven)
        {
            if (cashGiven >= CoffeePrice)
            {
                this.Money += CoffeePrice;
                this.CoffeeSold++;
                return true;
            }
            return false;
        }

        public bool BuyLunchWithCard(PaymentCard card)
        {
            if (card.TakeMoney(LunchPrice))
            {
                this.LunchSold++;
                return true;
            }
            return false;
        }

        public bool BuyCoffeeWithCard(PaymentCard card)
        {
            if (card.TakeMoney(CoffeePrice))
            {
                this.CoffeeSold++;
                return true;
            }
            return false;
        }

        public void AddMoneyToCard(PaymentCard card, double amount)
        {
            if (amount > 0)
            {
                card.AddMoney(amount);
                this.Money += amount;
            }
        }

        public override string ToString()
        {
            return $"Money in register: {this.Money:0.00} EUR\n" +
                   $"Lunches sold: {this.LunchSold}\n" +
                   $"Coffees sold: {this.CoffeeSold}";
        }
    }
}
