using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Library
    {
        public static List<Media> allLibraryList = new List<Media>() 
        {
            
        new Book("Ulysses",BookType.Book,false,"",0,90),
        new Book("Harry Potter",BookType.Book,false,"",0,110),
        new Book("The Great Gatsby",BookType.Book,false,"",0,150),
        new Book("One Hundred Years Of Solitude",BookType.Book,false,"",0,89),
        new Book("Hamlet",BookType.Book,false,"",0,100),
        new Book("Pride And Prejudice",BookType.Book,false,"",0,140),



       new Magazines("Time",BookType.Magazine,false,"",0,0,45),
       new Magazines("The New Yorker",BookType.Magazine,false,"",0,0,120),
       new Magazines("Peple",BookType.Magazine,false,"",0,0,16),
       new Magazines("The Little Review",BookType.Magazine,false,"",0,0,123),
       new Magazines("Vogue",BookType.Magazine,false,"",0,0,45),
       new Magazines("Loaded",BookType.Magazine,false,"",0,0,50),


       new Movie("The God Father",BookType.Movie,false,"",0,120),
       new Movie("Star Wars",BookType.Movie,false,"",0,200),
       new Movie("Back To The Future",BookType.Movie,false,"",0,180),
       new Movie("The Dark Knight",BookType.Movie,false,"",0,450),
       new Movie("The Matrix",BookType.Movie,false,"",0,600)
    };
        }
}
