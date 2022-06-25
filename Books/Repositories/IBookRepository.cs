using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Repositories
{
  public   interface IBookRepository
    {
       public IEnumerable<Book> GetAllBook();

      public   Book GetBookid(int id);

       public  int DeleteBook(int id);

       public Book Create(Book book);

       public  Book  UpdateBook(Book book);


    }
}
