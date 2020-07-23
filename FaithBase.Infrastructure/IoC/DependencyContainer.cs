using FaithBase.Application.Interfaces;
using FaithBase.Application.Services;
using FaithBase.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FaithBase.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IPostService, PostService>();

            // CleanArchitecture.Infrastructure.Data.Repositories
            services.AddScoped<IPostRepository, PostRepository>();
        }
    }
}