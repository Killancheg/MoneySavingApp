using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<BalanceChange> BalanceChanges { get; set; }
    
    public DbSet<BalanceChangeCategory> BalanceChangeCategories { get; set; }
    
    public DbSet<Wallet> Wallets { get; set; }
}