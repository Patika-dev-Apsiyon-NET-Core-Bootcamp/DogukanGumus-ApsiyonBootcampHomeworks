using System;
using System.Collections.Generic;

namespace FoodAppHomework.Domain.Models
{
    public class Food:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
