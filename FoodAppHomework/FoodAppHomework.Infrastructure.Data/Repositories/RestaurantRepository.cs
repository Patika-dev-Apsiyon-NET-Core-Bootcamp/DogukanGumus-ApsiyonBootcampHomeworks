using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FoodAppHomework.Infrastructure.Data.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(FoodAppDbContext foodAppDbContext) : base(foodAppDbContext)
        {

        }

        
    }
}
