using System.Net.Http.Json;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Services;

public class BalanceChangeService : IBalanceChangeService
{
    private readonly HttpClient _http;
    
    public BalanceChangeService(HttpClient http)
    {
        _http = http;
    }

    public async Task<IEnumerable<BalanceChange>?> GetWalletsIncomeAsync(int walletId)
    {
        return await _http.GetFromJsonAsync<IEnumerable<BalanceChange>>($"api/Income/Wallet/{walletId}");
    }
}