using System.ComponentModel.DataAnnotations;

namespace BookInSession.Models
{
    public class BookModel
    {
        [Required(ErrorMessage = "Her kitabın bir Id değeri olmalıdır.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Her kitabın bir ismi olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Her kitabın bir yazarı olmalıdır.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Her kitabın bir fiyatı olmalıdır.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Her kitabın bir kategorisi olmalıdır.")]
        public int CategoryId { get; set; }
    }
}