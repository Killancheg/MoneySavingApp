using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess.Services;

public class BalanceChangeDtoService : BaseModelService<BalanceChangeDto>, IBalanceChangeDtoService
{
    public BalanceChangeDtoService(DataContext context)
        : base(context)
    {
    }

    public async Task<IEnumerable<BalanceChangeDto>> GetWalletsIncomeAsync(int walletId)
    {
        return await Entities.Where(change => change.WalletId == walletId).ToListAsync();
    }
}