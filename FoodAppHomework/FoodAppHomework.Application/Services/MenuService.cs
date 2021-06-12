using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Domain.UnitOfWork;

namespace FoodAppHomework.Application.Services
{
    public class MenuService : Service<Menu>, IMenuService
    {
        public MenuService(IUnitOfWork unitOfWork, IRepository<Menu> repository):base(unitOfWork, repository)
        {

        }
        public async Task<List<Menu>> GetMenuByRestaurant(int restaurantId)
        {
            return await _unitOfWork.Menus.GetMenuByRestaurant(restaurantId);
        }
    }
}
