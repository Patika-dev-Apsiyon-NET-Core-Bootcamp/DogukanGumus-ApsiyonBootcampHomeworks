using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.Entities.Concrete;
using WeekThreeHomework.WebUI.Models;

namespace WeekThreeHomework.WebUI.Controllers
{
    public class HomeController:Controller
    {
        private IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public IActionResult Index(string query, int categoryId = 0, int page = 1 )
        {
            int pageSize = 3;
            var articles = _articleService.GetByCategoryId(categoryId);
            ArticleListViewModel model = new ArticleListViewModel()
            {
                Articles =  articles
                    .Skip((page - 1) * pageSize).Take(pageSize)
                    .ToList(),
                PageCount = (int)Math.Ceiling(articles.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page
            }; 
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var article =  _articleService.GetArticleWithComments(id);
            ArticleDetailModel model = new ArticleDetailModel()
            {
                Article = article
            };
            return View(model);
        }
    }
}