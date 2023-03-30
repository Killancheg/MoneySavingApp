using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Services;

public interface IBalanceChangeService
{
    Task<IEnumerable<BalanceChange>?> GetWalletsBalanceChangesAsync(int walletId);
}