using System;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.UnitOfWork;
using FoodAppHomework.Infrastructure.Data.Context;
using FoodAppHomework.Infrastructure.Data.Repositories;

namespace FoodAppHomework.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FoodAppDbContext _context;

        private FoodRepository _foodRepository { get; set; }
        private MenuRepository _menuRepository { get; set; }
        private RestaurantRepository _restaurantRepository { get; set; }

        public IFoodRepository Foods => _foodRepository = _foodRepository ?? new FoodRepository(_context);

        public IMenuRepository Menus => _menuRepository = _menuRepository ?? new MenuRepository(_context);

        public IRestaurantRepository Restaurants => _restaurantRepository = _restaurantRepository ?? new RestaurantRepository(_context);


        public UnitOfWork(FoodAppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
