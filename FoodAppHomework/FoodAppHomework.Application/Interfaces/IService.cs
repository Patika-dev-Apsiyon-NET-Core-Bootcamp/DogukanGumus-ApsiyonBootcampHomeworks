using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Models;

namespace FoodAppHomework.Application.Interfaces
{
    public interface IService<TEntity> where TEntity:Entity, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
