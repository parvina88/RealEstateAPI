using Application.Services;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Building>, BuildingService>();
            return services;
        }
    }
}
