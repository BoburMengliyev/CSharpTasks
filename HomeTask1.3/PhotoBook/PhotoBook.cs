﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13.PhotoBook
{
    internal class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }


        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages() 
        {
            return numPages;
        }
    }
}
