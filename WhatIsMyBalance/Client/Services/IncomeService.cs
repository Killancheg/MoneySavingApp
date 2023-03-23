using System.Net.Http.Json;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Services;

public class IncomeService : IIncomeService
{
    private readonly HttpClient _http;
    
    public IncomeService(HttpClient http)
    {
        _http = http;
    }

    public async Task<IEnumerable<Income>?> GetWalletsIncome(int walletId)
    {
        return await _http.GetFromJsonAsync<IEnumerable<Income>>($"api/Income?walletId={walletId}");
    }
}