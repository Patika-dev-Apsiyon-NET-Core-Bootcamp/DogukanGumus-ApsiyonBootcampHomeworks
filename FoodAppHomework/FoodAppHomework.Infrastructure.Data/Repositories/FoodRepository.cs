using System;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Infrastructure.Data.Context;

namespace FoodAppHomework.Infrastructure.Data.Repositories
{
    public class FoodRepository:Repository<Food>, IFoodRepository
    {
        public FoodRepository(FoodAppDbContext foodAppDbContext):base(foodAppDbContext)
        {

        }
    }
}
