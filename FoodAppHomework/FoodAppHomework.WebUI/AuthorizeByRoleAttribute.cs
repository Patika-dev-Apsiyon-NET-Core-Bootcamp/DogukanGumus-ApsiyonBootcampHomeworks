using System;
using Microsoft.AspNetCore.Authorization;

namespace FoodAppHomework.WebUI
{
    public class AuthorizeByRoleAttribute : AuthorizeAttribute
    {
        public AuthorizeByRoleAttribute(params string[] roles)
        {

            Roles = string.Join(",", roles);
        }

    }
}
