using System.ComponentModel.DataAnnotations;

namespace WeekThreeHomework.WebUI.Areas.Admin.Models
{
    public class ArticleUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public int CategoryId { get; set; }
    }
}