using System;
using System.ComponentModel.DataAnnotations;

namespace BookInSession.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Her kullanıcının bir kullanıcı adı olmalıdır.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Her kullanıcının bir adı olmalıdır.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Her kullanıcının bir soyadı olmalıdır.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Her kullanıcının bir emaisl adresi olmalıdır.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Her kullanıcının bir parolası olmalıdır.")]
        public string Password { get; set; }
    }
}
