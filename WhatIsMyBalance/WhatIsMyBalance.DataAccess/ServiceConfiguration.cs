using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WhatIsMyBalance.DataAccess;

public static class ServiceConfiguration
{
    public static void AddDbServices(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }

}