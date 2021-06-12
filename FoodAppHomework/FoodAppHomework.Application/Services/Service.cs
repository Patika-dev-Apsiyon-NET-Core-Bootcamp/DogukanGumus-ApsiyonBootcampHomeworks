using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Domain.UnitOfWork;

namespace FoodAppHomework.Application.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity, new()
    {
        public IUnitOfWork _unitOfWork;
        public readonly IRepository<TEntity> _repository;
        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }
        
        public async Task<List<TEntity>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
          return await _repository.GetByIdAsync(id);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
