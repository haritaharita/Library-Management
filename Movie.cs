using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Movie : Media
    {
        int StartTime { get; set; }
        public Movie(string title, BookType type, bool availability, string borrower, int lendTime, int startTime) : base(title, type, availability, borrower, lendTime)
        {
            StartTime = startTime;
        }
    }

}
