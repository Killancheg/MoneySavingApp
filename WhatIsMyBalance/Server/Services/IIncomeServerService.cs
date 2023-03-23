using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Services;

public interface IIncomeServerService
{
    Task<IEnumerable<Income>> GetWalletsIncome(int walletId);
}