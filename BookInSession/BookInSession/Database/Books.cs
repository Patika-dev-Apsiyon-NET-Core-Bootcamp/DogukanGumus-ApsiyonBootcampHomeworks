using System.Collections.Generic;
using System.Linq;
using BookInSession.Models;

namespace BookInSession.Database
{
    public static class Books
    {
        private static List<BookModel> _books;
        static Books()
        {
            _books = new List<BookModel>()
            {
                new BookModel(){Id = 1, Name = "Kan Varsa", Author = "Stephen King", Price = 35 , CategoryId = 1},
                new BookModel(){Id = 2, Name = "Gece Yarısı Kütüphanesi", Author = "Matt Haig", Price = 26, CategoryId = 2},
                new BookModel(){Id = 3, Name = "Simyacı", Author = "Paulo Coelho", Price = 19, CategoryId = 2},
                new BookModel(){Id = 4, Name = "Hayvan Çiftliği", Author = "George Orwell", Price = 7, CategoryId = 2},
                new BookModel(){Id = 5, Name = "Proje:Ölümcül Virüs", Author = "Tess Gerritsen", Price = 29, CategoryId = 1},
                new BookModel(){Id = 6, Name = "Tutunamayanlar", Author = "Oğuz Atay", Price = 42, CategoryId = 3},
                new BookModel(){Id = 7, Name = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", Price = 5, CategoryId = 3},
            };
        }

        public static List<BookModel> BookList
        {
            get
            {
                return _books;
            }
        }
      
    }

}