using System.Collections.Generic;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.WebUI.Areas.Admin.Models
{
    public class ArticleAdminListViewModel
    {
        public List<Article> Articles { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
    }
}