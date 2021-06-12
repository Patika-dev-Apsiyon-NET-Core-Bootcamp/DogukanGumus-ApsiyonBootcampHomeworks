﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodAppHomework.WebUI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;
        private readonly IFoodService _foodService;
        public MenuController(IMenuService menuService, IMapper mapper, IFoodService foodService)
        {
            _menuService = menuService;
            _mapper = mapper;
            _foodService = foodService;
        }
        public async Task<IActionResult> Index(int restaurantId)
        {
            List<MenuDto> menuDtos = new List<MenuDto>();
            var menus = await _menuService.GetMenuByRestaurant(restaurantId);
            foreach (var menu in menus)
            {
                MenuDto menuDto = new MenuDto()
                {
                    Id = menu.Id,
                    Name = menu.Name,
                    Description = menu.Description,
                    Foods = _mapper.Map<ICollection<FoodDto>>(menu.Foods)
                };

                menuDtos.Add(menuDto);
            }
            return View(menuDtos);
        }

    }
}
