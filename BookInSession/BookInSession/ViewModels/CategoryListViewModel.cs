using System;
using System.Collections.Generic;
using BookInSession.Models;

namespace BookInSession.ViewModels
{
    public class CategoryListViewModel
    {
        public List<CategoryModel> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}
