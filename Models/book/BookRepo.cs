using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersCCV2.Models.book
{
    public class BookRepo : IBook
    {
        public Book getBookByTitle(string title)
        {
            return getBooks().FirstOrDefault(p => p.bTitle == title);
        }

        public IEnumerable<Book> getBooks() =>
            new List<Book>
            {
                new Book{ISBN = "978-0-670-81364-3", image="~/images/Books/Misery.jpg", aFirstName = "Stephen", aLastName = "King", edition = "n/a", bTitle= "Misery", pDate = "June 8, 1987", notes = "I'm a pretty decent Stephen King fan, and while it took a couple attemps to read this book I liked it in the end." },
                new Book{ISBN = "978-0670315413", image="~/images/Books/Firestarter.jpg", aFirstName = "Stephen", aLastName = "King", edition = "n/a", bTitle= "Firestarter", pDate = "September 29, 1980",  notes = "A drug that gives unatural abilities? A secret government agency? What's not to like?", },
                new Book{ISBN = "0-440-21172-7", image="~/images/Books/ATTK.jpg", aFirstName = "John", aLastName = "Grisham", edition = "n/a", bTitle= "A Time to Kill", pDate = "1989", notes = "I read this book a bit young, but I sought out many Grisham novels afterwards as this was only the beginning" },
                new Book{ISBN = "978-0345531926", image="~/images/Books/TClient.jpg", aFirstName = "John", aLastName = "Grisham", edition = "n/a", bTitle= "The Client", pDate = "1993", notes = "Perhaps not the best method, btu readling John Grisham's novels is what made me so interested in going to law school"  },
                new Book{ISBN = "0-670-81302-8", image="~/images/Books/IT.jpg", aFirstName = "Stephen", aLastName = "King", edition = "n/a", bTitle= "IT", pDate = "September 15, 1986", notes = "Ok, I haven't actually finished this book, but it one of my favorites simply because I've have attempted to read it so much. I either get bored or just stop for some reason."}
            };
    }
}
