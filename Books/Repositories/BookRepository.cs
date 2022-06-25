using Books.Data;
using Books.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Repositories
{
    public class BookRepository : IBookRepository
    {
        BookDbContext _dbContext;
        public BookRepository(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Book  Create(Book book)
        {
             _dbContext.Books.Add(book);
             _dbContext.SaveChanges();
            return book;
        }

        public   int DeleteBook(int id)
        {
            int result = 0;
            var book =  _dbContext.Books.FirstOrDefault(x => x.id == id);
            int bo = book.id;
            if(book!=null)
            {
                _dbContext.Remove(book);
                _dbContext.SaveChanges();
                result = _dbContext.SaveChanges();

            }
            return bo;
        }

        public   IEnumerable<Book> GetAllBook()
        {
            return _dbContext.Books;              
        }

        public  Book GetBookid(int id)
        {
            return _dbContext.Books.FirstOrDefault(d=>d.id==id);
                
        }

        public  Book  UpdateBook(Book book)
        {
           _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
            return book;
        }

      

     

    }
}
