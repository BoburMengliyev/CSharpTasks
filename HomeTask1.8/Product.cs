using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18
{
    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public void PrintProduct() 
        {
            Console.WriteLine(
           $"""
            {name}: price {price}: {quantity} pcs
            """);
        }
    }
}
