﻿using Application.Services;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBaseService<Building>, BuildingService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}