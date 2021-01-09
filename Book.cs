using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    
        public class Book : Media
        {

            public int NumberOfPages { get; private set; }

            public Book(string title, BookType type, bool availability, string borrower, int lendTime, int numberOfPages) : base(title, type, availability, borrower, lendTime)
            {
              NumberOfPages = numberOfPages;
            }
        }
    }



