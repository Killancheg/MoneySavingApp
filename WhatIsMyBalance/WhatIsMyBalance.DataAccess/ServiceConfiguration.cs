using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WhatIsMyBalance.DataAccess.Services;

namespace WhatIsMyBalance.DataAccess;

public static class ServiceConfiguration
{
    public static void AddDbServices(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IBalanceChangeDtoService, BalanceChangeDtoService>();
        services.AddScoped<ICategoryDtoService, CategoryDtoService>();
        services.AddScoped<IWalletDtoService, WalletDtoService>();
    }

}