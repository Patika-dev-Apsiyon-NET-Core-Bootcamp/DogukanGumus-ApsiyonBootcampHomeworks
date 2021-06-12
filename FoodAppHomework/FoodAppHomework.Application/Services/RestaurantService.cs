using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Domain.UnitOfWork;

namespace FoodAppHomework.Application.Services
{
    public class RestaurantService : Service<Restaurant>, IRestaurantService
    {
        public RestaurantService(IUnitOfWork unitOfWork, IRepository<Restaurant> repository) : base(unitOfWork, repository)
        {

        }

      
    }
}
