using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask15.Book
{
    public class Book : AbstractBook, IBorrowable
    {
        public void Borrow() 
        {
            Console.WriteLine("Kitob olingan");
        }
        public void ReturnBook() 
        {
            Console.WriteLine("Kitob qaytarilgan");
        }
    }
}
