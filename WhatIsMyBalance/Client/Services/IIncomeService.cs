using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Services;

public interface IIncomeService
{
    Task<IEnumerable<Income>?> GetWalletsIncome(int walletId);
}