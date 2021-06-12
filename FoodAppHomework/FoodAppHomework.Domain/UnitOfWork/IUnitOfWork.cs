using System;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Interfaces;

namespace FoodAppHomework.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IFoodRepository Foods { get;}
        public IMenuRepository Menus { get; }
        public IRestaurantRepository Restaurants { get; }

        Task CommitAsync();

        void Commit();
    }
}
