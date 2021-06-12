using System;
using System.Collections.Generic;

namespace FoodAppHomework.Domain.Models
{
    public class Restaurant:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
