using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FoodAppHomework.Infrastructure.Data.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(FoodAppDbContext foodAppDbContext) : base(foodAppDbContext)
        {

        }

        public async Task<List<Menu>> GetMenuByRestaurant(int restaurantId)
        {
           return await _context.Menus
                .Where(i => i.RestaurantId == restaurantId)
                .Include(f=>f.Foods)
                .ToListAsync();        
        }
    }
}
