using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsDA;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsIdentity;

namespace WhatIsMyBalance.DataAccess;

public class DataContext : IdentityDbContext<ApplicationUser>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<BalanceChangeDto> BalanceChanges { get; set; }
    
    public DbSet<CategoryDto> Categories { get; set; }
    
    public DbSet<WalletDto> Wallets { get; set; }
}