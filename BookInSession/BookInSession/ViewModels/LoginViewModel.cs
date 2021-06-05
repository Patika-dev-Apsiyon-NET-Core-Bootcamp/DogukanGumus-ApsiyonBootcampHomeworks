using System;
using System.ComponentModel.DataAnnotations;

namespace BookInSession.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Her kullanıcının bir kullanıcı adı olmalıdır.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Her kullanıcının bir parolası olmalıdır.")]
        public string Password { get; set; }
    }
}
