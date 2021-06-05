using System;
using Microsoft.AspNetCore.Mvc;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.WebUI.Areas.Admin.Models;

namespace WeekThreeHomework.WebUI.Areas.Admin.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAll();
            CategoryAdminListViewModel model = new CategoryAdminListViewModel()
            {
                Categories =  categories,
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["categoryId"])
            }; 
            return View(model);
        }
    }
}