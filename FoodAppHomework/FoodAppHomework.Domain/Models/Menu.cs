using System;
using System.Collections.Generic;

namespace FoodAppHomework.Domain.Models
{
    public class Menu:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int RestaurantId { get; set; }
        public  Restaurant Restaurant { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
