using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.ViewModels
{
    public class HomeIndextViewModel
    {
       public  IEnumerable<Book> GetBooksAll { get; set; }
        public Book GetBookid { get; set; }
        public string Title { get; set; }
    }
}
