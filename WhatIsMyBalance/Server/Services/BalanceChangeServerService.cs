using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.Server.Data;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Services;

public class BalanceChangeServerService : IBalanceChangeServerService
{
    private readonly DataContext _context;
    
    public BalanceChangeServerService(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BalanceChange>> GetWalletsIncomeAsync(int walletId)
    {
        return await _context.BalanceChanges.Where(change => change.WalletId == walletId).ToListAsync();
    }
}