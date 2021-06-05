using System;
using System.Collections.Generic;
using System.Linq;
using BookInSession.Database;
using BookInSession.ExtensionMethods;
using BookInSession.Models;
using BookInSession.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookInSession.Controllers
{
    public class HomeController : Controller
    {
        List<BookModel> _bookModel;
        public HomeController()
        {
            _bookModel = Books.BookList;
        }

        public IActionResult Index(int page = 1, int categoryId = 0)
        {
            int pageSize = 3;
            HttpContext.Session.SetObject("book", _bookModel);

            var books = HttpContext.Session.GetObject<List<BookModel>>("book").Where(b => b.CategoryId == categoryId || categoryId == 0).ToList();
            BookListViewModel bookListViewModel = new BookListViewModel()
            {
                Books = books.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(books.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page
            };
            return View(bookListViewModel);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                _bookModel.Add(bookModel);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            var book =  _bookModel.Where(b=>b.Id == id).FirstOrDefault();
            if (book != null)
            {
                return View(book);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                var bookToUpdate = _bookModel.Where(b => b.Id == bookModel.Id).FirstOrDefault();
                if (bookToUpdate != null)
                {
                    bookToUpdate.Id = bookModel.Id;
                    bookToUpdate.Name = bookModel.Name;
                    bookToUpdate.Author = bookModel.Author;
                    bookToUpdate.Price = bookModel.Price;
                    bookToUpdate.CategoryId = bookModel.CategoryId;
                    return RedirectToAction("Index");
                }
                return View();
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var bookToDelete = _bookModel.Where(b => b.Id == id).FirstOrDefault();
            _bookModel.Remove(bookToDelete);
            return RedirectToAction("Index");
        }
    }
}



