using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Models;

namespace FoodAppHomework.Application.Interfaces
{
    public interface IMenuService: IService<Menu>
    {
        Task<List<Menu>> GetMenuByRestaurant(int restaurantId);
    }
}
