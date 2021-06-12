using System;
using AutoMapper;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.WebUI.Models;

namespace FoodAppHomework.WebUI.Profiles
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
        }
    }
}
