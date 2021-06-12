using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using FoodAppHomework.Application.Services;
using FoodAppHomework.Application.Interfaces;
using FoodAppHomework.Domain.Interfaces;
using FoodAppHomework.Infrastructure.Data.Repositories;
using FoodAppHomework.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using FoodAppHomework.Infrastructure.Data.UnitOfWork;
using FoodAppHomework.Domain.UnitOfWork;

namespace FoodAppHomework.Application.DependencyResolvers
{
    public static class StartupServiceExtension
    {
       public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
       {
            services.AddDbContext<FoodAppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();

            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<IMenuService, MenuService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            return services;
       }
    }
}
