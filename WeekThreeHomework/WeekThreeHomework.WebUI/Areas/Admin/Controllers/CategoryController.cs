using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.Entities.Concrete;
using WeekThreeHomework.WebUI.Areas.Admin.Models;

namespace WeekThreeHomework.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController:Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public IActionResult Index(int page=1)
        {
            int pageSize = 3;
            var categories = _categoryService.GetAll();
            CategoryAdminListViewModel model = new CategoryAdminListViewModel()
            {
                Categories =  categories.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(categories.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentPage = page
            }; 
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(CategoryAddViewModel categoryAddViewModel)
        {
            Category category = new Category()
            {
                Name = categoryAddViewModel.Name,
                Description = categoryAddViewModel.Description
            };
            _categoryService.Add(category);
            TempData.Add("message","Yeni kategori başarıyla eklenmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoryService.Get(id);
            if (category != null)
            {
                CategoryUpdateViewModel categoryUpdateViewModel = new CategoryUpdateViewModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                };
                return View(categoryUpdateViewModel);
            }

            TempData.Add("message","Böyle bir kategori bulunmamaktadır.");
            return View();
        }

        [HttpPost]
        public IActionResult Update(CategoryUpdateViewModel categoryUpdateViewModel)
        {
            Category category = new Category()
            {
                Id = categoryUpdateViewModel.Id,
                Name = categoryUpdateViewModel.Name,
                Description = categoryUpdateViewModel.Description
            };
            _categoryService.Update(category);
            TempData.Add("message","Kategori başarıyla güncellenmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var categoryToDelete = _categoryService.Get(id);
            if (categoryToDelete != null)
            {
                _categoryService.Delete(categoryToDelete);
                return RedirectToAction("Index");
            }
            TempData.Add("message","Böyle bir kategori bulunmamaktadır.");
            return RedirectToAction("Index");
        }
    }
}