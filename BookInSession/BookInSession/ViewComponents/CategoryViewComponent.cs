using System;
using BookInSession.Database;
using BookInSession.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookInSession.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private Categories _categories = new Categories();
        public IViewComponentResult Invoke()
        {
            var categories = _categories.GetAll();
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel()
            {
                Categories = categories,
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["categoryId"])
            };
            
            return View(categoryListViewModel);
        }
    }
}