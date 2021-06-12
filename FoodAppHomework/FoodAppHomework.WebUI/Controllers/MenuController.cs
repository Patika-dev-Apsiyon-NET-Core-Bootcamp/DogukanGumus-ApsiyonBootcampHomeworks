using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.WebUI.Enums;
using FoodAppHomework.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodAppHomework.WebUI.Controllers
{
    [AuthorizeByRole(Roles.Admin)]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;
        public MenuController(IMenuService menuService, IMapper mapper)
        {
            _menuService = menuService;
            _mapper = mapper;
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
