using System;
using System.Collections.Generic;
using FoodAppHomework.Domain.Models;

namespace FoodAppHomework.WebUI.Models
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<FoodDto> Foods { get; set; }
    }
}
