using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.Business.Concrete;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.DataAccess.Concrete.EntityFramework;
using WeekThreeHomework.WebUI.Extensions;

namespace WeekThreeHomework.WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencyInjection();
            services.AddControllersWithViews();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name:"Admin",
                    areaName:"Admin",
                    pattern:"Admin/{controller=Category}/{action=Index}/{id?}"
                    );
                
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}