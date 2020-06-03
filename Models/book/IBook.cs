using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersCCV2.Models.book
{
    public interface IBook
    {
        IEnumerable<Book> getBooks();
        Book getBookByTitle(string title);
    }
}
