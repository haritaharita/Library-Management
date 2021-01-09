using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Magazines : Book
    {
        int IssueNumbers { get; set; }
        public Magazines(string title, BookType type, bool availability, string borrower, int lendTime, int pageCount, int issueNumbers) : base(title, type, availability, borrower, lendTime, pageCount)
        {
            IssueNumbers = issueNumbers;
        }

       
}
}
