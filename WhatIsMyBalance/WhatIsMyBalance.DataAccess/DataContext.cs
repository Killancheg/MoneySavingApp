using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<BalanceChangeDto> BalanceChanges { get; set; }
    
    public DbSet<CategoryDto> Categories { get; set; }
    
    public DbSet<WalletDto> Wallets { get; set; }
}