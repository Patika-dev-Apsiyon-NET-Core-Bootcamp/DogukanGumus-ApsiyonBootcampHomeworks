using Microsoft.AspNetCore.Identity;

namespace ServiceToConsume.Core.Models
{
    public class UserApp:IdentityUser
    {
        public string City { get; set; }
    }
}