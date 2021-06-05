using Microsoft.Extensions.DependencyInjection;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.Business.Concrete;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.DataAccess.Concrete.EntityFramework;

namespace WeekThreeHomework.WebUI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticleDal, EfArticleDal>();
            
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            return services;
        }
    }
}