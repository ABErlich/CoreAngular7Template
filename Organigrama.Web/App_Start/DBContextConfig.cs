using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Organigrama.Models.Context;

namespace Organigrama.Web.App_Start
{
    public class DBContextConfig
    {
        public static void Initialize(IConfiguration config, IHostingEnvironment env, IServiceProvider serviceProvider){
            var optionsBuilder = new DbContextOptionsBuilder();

            if(env.IsDevelopment()){
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));    
            } else if(env.IsStaging()){
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));  
            } else if(env.IsProduction()){
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));    
            }

            var context = new ApplicationContext(optionsBuilder.Options);

            if(context.Database.EnsureCreated()){
                IUserMap service = serviceProvider.GetService(typeof(IUserMap)) as IUserMap;
                new DBInitializeConfig(service).DataTest();
            }
        }

        public static void Initialize(IServiceCollection services, IConfiguration config){
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        }
    }
}
