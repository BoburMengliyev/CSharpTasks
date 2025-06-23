using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask15.Book
{
    public abstract class AbstractBook : IReadable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void Read() 
        {
            Console.WriteLine("The book is being read.");
        }
    }
}
