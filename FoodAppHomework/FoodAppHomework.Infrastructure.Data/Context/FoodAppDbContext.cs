using System;
using FoodAppHomework.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAppHomework.Infrastructure.Data.Context
{
    public class FoodAppDbContext:DbContext
    {
        public FoodAppDbContext(DbContextOptions<FoodAppDbContext> options):base(options)
        {

        }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
