using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask15.Book
{
    public interface IBorrowable
    {
        void Borrow();
        void ReturnBook();
    }
}