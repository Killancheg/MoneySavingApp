using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Services;

public interface IBalanceChangeServerService
{
    Task<IEnumerable<BalanceChange>> GetWalletsIncomeAsync(int walletId);
}