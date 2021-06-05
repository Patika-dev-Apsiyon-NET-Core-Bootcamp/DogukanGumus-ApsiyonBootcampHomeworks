using System.ComponentModel.DataAnnotations;

namespace WeekThreeHomework.WebUI.Areas.Admin.Models
{
    public class CommentUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public int ArticleId { get; set; }
    }
}