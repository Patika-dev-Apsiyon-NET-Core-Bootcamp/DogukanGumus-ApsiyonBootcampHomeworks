using System.Collections.Generic;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.WebUI.Areas.Admin.Models
{
    public class CommentAdminListViewModel
    {
        public List<Comment> Comments { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}