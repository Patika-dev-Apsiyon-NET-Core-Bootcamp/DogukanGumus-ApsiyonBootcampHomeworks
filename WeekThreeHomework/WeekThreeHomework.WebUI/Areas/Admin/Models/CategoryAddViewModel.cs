using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.WebUI.Areas.Admin.Models
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
        public string Description { get; set; }
    }
}