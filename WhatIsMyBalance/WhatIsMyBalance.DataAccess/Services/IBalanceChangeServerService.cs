using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess.Services;

public interface IBalanceChangeServerService
{
    Task<IEnumerable<BalanceChangeDto>> GetWalletsIncomeAsync(int walletId);
}