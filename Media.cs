using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   
        public enum BookType { Book, Magazine, Movie };

        public class Media
        {
            public string Title { get; set; }
            public BookType Type { get; set; }
            public Boolean Availability { get; set; }
            public string Borrower { get; set; }
            public string Author { get; set; }
            public static int SerialNumber { get; private set; }
            public int LendTime { get; private set; }
        public string Name { get; internal set; }

        public Media(string title, BookType type, bool availability, string borrower,string author)
            {
                SerialNumber++;
                Title = title;
                Type = type;
                Availability = availability;
                Borrower = borrower;
                Author = author;
            }
            public Media(string title, BookType type, bool availability, string borrower, int lendTime)
            {
                SerialNumber++;
                Title = title;
                Type = type;
                Availability = availability;
                Borrower = borrower;
                LendTime = lendTime;
            }

        }
    }
