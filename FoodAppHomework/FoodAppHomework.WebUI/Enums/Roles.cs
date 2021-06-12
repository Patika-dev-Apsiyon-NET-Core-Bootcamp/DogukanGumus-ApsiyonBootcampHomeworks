using System;
using System.ComponentModel;

namespace FoodAppHomework.WebUI.Enums
{
    public static class Roles
    {
        public const string Admin = "Admin";
    }

    public enum RoleTypes:byte
    {
        [Description(Roles.Admin)]
        Admin = 1
    }
}
