﻿namespace WhatIsMyBalance.Server.Mappers;

public static class MapperInjectionService
{
    public static void AddMappers(this IServiceCollection services)
    {
        services.AddScoped<BalanceChangeMapper>();
    }
}