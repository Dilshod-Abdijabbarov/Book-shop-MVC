using Books.Data;
using Books.Models;
using Books.Repositories;
using Books.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IBookRepository _repository;
        public HomeController(IBookRepository repository)
        {
            _repository = repository;
        }

        

        public ViewResult Index()
        {
            HomeIndextViewModel viewmodel = new HomeIndextViewModel()
            {
                GetBooksAll = _repository.GetAllBook()
            };

            return View(viewmodel);
        }


        public ViewResult Details(int? id)
        {

            var GetBookid = _repository.GetBookid(id ?? 1);             
          
            return View("Details",GetBookid);
        }


        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var book = _repository.GetBookid(id);
            HomeCreateViewModel bookEdit = new HomeCreateViewModel()
            {
                id = book.id,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price
            };

            return View(bookEdit);
        }

        [HttpPost]
      public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                var qosh = _repository.Create(book);

                return RedirectToAction("Details", new { id = qosh.id });
            }

            return View();
        }


        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                var qosh = _repository.UpdateBook(book);

                return RedirectToAction("Details", new { id = qosh.id });
            }

            return View();
        }


        public IActionResult Delete(int id)
        {
            _repository.DeleteBook(id);

            return RedirectToAction("Index");
        }
    }
}
