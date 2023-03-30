using System.ComponentModel.DataAnnotations.Schema;

namespace WhatIsMyBalance.DataAccess.ModelsDA;

public class BalanceChangeDto
{
    public int Id { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }
    
    public string Description { get; set; }
    
    public WalletDto Wallet { get; set; }
    
    public int WalletId { get; set; }
    
    public CategoryDto Category { get; set; }
    
    public int CategoryId { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    
    public DateTime DateChanged { get; set; }
}