using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Services;

public class IncomeServerService : IIncomeServerService
{
    public async Task<IEnumerable<Income>> GetWalletsIncome(int walletId)
    {
        return new List<Income>();
    }
}