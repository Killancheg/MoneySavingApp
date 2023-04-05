using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess.Services;

public interface IBalanceChangeDtoService : IBaseModelService<BalanceChangeDto>
{
    Task<IEnumerable<BalanceChangeDto>> GetWalletsIncomeAsync(int walletId);
}