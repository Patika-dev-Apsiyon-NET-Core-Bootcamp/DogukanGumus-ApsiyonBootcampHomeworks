using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Domain.Models;
using FoodAppHomework.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FoodAppHomework.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        public readonly FoodAppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(FoodAppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
           return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(r=>r.Id == id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
