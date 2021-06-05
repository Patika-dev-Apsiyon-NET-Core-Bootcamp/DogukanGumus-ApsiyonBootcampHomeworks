using System.ComponentModel.DataAnnotations;

namespace WeekThreeHomework.WebUI.Areas.Admin.Models
{
    public class CategoryUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Description { get; set; }
    }
}