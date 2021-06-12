using System;
using System.ComponentModel.DataAnnotations;

namespace FoodAppHomework.WebUI.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
