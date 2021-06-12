using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Domain.UnitOfWork;

namespace FoodAppHomework.Application.Services
{
    public class FoodService : Service<Food>, IFoodService
    {
        public FoodService(IUnitOfWork unitOfWork, IRepository<Food> repository) : base(unitOfWork, repository)
        {

        }
    }
}
