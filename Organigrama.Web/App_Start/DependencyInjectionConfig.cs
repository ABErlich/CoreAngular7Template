using System;
using Microsoft.Extensions.DependencyInjection;
using Organigrama.Mappers;
using Organigrama.Models.Context;
using Organigrama.Repositories;
using Organigrama.Services;

namespace Organigrama.Web.App_Start
{
    public class DependencyInjectionConfig
    {
		public static void AddScope(IServiceCollection services){
            services.AddScoped<IApplicationContext, ApplicationContext>();
            services.AddScoped<IUserMap, UserMap>();
            services.AddScoped<IUserService, UserService>();
            services.AddScioed<IUserRepository, UserRepository>();
		}
    }
}
