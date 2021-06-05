using System;
using System.Collections.Generic;
using BookInSession.Models;

namespace BookInSession.ViewModels
{
    public class BookListViewModel
    {
        public List<BookModel> Books { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
    }
}
