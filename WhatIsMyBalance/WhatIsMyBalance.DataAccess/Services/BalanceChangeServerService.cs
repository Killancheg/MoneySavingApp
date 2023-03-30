using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess.Services;

public class BalanceChangeServerService : IBalanceChangeServerService
{
    private readonly DataContext _context;
    
    public BalanceChangeServerService(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BalanceChangeDto>> GetWalletsIncomeAsync(int walletId)
    {
        return await _context.BalanceChanges.Where(change => change.WalletId == walletId).ToListAsync();
    }
}