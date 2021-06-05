using System;
using Microsoft.AspNetCore.Mvc;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.WebUI.Models;

namespace WeekThreeHomework.WebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAll();
            CategoryListViewModel model = new CategoryListViewModel()
            {
                Categories =  categories,
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["categoryId"])
            }; 
            return View(model);
        }
    }
}