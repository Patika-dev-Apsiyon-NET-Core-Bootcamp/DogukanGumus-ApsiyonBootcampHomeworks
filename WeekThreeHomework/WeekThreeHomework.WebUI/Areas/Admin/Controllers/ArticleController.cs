using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.Entities.Concrete;
using WeekThreeHomework.WebUI.Areas.Admin.Models;

namespace WeekThreeHomework.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController:Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        
        [HttpGet]
        public IActionResult Index(int categoryId = 0, int page = 1)
        {
            int pageSize = 3;
            var articles = _articleService.GetByCategoryId(categoryId);
            ArticleAdminListViewModel model = new ArticleAdminListViewModel()
            {
                Articles =  articles.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(articles.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
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
        public IActionResult Add(ArticleAddViewModel articleAddViewModel)
        {
            Article article = new Article()
            {
                Title = articleAddViewModel.Title,
                Content = articleAddViewModel.Content,
                Author = articleAddViewModel.Author,
                CategoryId = articleAddViewModel.CategoryId
            };
            _articleService.Add(article);
            TempData.Add("message","Yeni makale başarıyla eklenmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var article = _articleService.Get(id);
            if (article != null)
            {
                ArticleUpdateViewModel articleUpdateViewModel = new ArticleUpdateViewModel()
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content,
                    Author = article.Author,
                    CategoryId = article.CategoryId
                };
                return View(articleUpdateViewModel);
            }

            TempData.Add("message","Böyle bir makale bulunmamaktadır.");
            return View();
        }

        [HttpPost]
        public IActionResult Update(ArticleUpdateViewModel articleUpdateViewModel)
        {
            Article article = new Article()
            {
                Id = articleUpdateViewModel.Id,
                Title = articleUpdateViewModel.Title,
                Content = articleUpdateViewModel.Content,
                Author = articleUpdateViewModel.Author,
                CategoryId = articleUpdateViewModel.CategoryId
            };
            _articleService.Update(article);
            TempData.Add("message","Makale başarıyla güncellenmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var articleToDelete = _articleService.Get(id);
            if (articleToDelete != null)
            {
                _articleService.Delete(articleToDelete);
                return RedirectToAction("Index");
            }
            TempData.Add("message","Böyle bir makale bulunmamaktadır.");
            return RedirectToAction("Index");
        }
    }
}