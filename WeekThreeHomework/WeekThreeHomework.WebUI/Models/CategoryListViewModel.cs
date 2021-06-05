using System.Collections.Generic;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}