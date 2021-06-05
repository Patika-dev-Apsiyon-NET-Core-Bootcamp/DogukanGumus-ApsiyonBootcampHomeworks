using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.Entities.Concrete;
using WeekThreeHomework.WebUI.Areas.Admin.Models;

namespace WeekThreeHomework.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController:Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        
        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            int pageSize = 3;
            var comments = _commentService.GetAll();
            CommentAdminListViewModel model = new CommentAdminListViewModel()
            {
                Comments =  comments.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(comments.Count / (double)pageSize),
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
        public IActionResult Add(CommentAddViewModel commentAddViewModel)
        {
            Comment comment = new Comment()
            {
                Text = commentAddViewModel.Text,
                ArticleId = commentAddViewModel.ArticleId
            };
            _commentService.Add(comment);
            TempData.Add("message","Yeni yorum başarıyla eklenmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var comment = _commentService.Get(id);
            if (comment != null)
            {
                CommentUpdateViewModel commentUpdateViewModel = new CommentUpdateViewModel()
                {
                   Id = comment.Id,
                   Text = comment.Text,
                   ArticleId = comment.ArticleId
                };
                return View(commentUpdateViewModel);
            }

            TempData.Add("message","Böyle bir yorum bulunmamaktadır.");
            return View();
        }

        [HttpPost]
        public IActionResult Update(CommentUpdateViewModel commentUpdateViewModel)
        {
            Comment comment = new Comment()
            {
                Id = commentUpdateViewModel.Id,
                Text = commentUpdateViewModel.Text,
                ArticleId = commentUpdateViewModel.ArticleId
            };
            _commentService.Update(comment);
            TempData.Add("message","Yorum başarıyla güncellenmiştir.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var commentToDelete = _commentService.Get(id);
            if (commentToDelete != null)
            {
                _commentService.Delete(commentToDelete);
                return RedirectToAction("Index");
            }
            TempData.Add("message","Böyle bir yorum bulunmamaktadır.");
            return RedirectToAction("Index");
        }
    }
}