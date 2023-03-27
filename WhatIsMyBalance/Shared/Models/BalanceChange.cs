using System.ComponentModel.DataAnnotations.Schema;

namespace WhatIsMyBalance.Shared.Models;

public class BalanceChange
{
    public int Id { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }
    
    public string Description { get; set; }
    
    public Wallet Wallet { get; set; }
    
    public int WalletId { get; set; }
    
    public BalanceChangeCategory Category { get; set; }
    
    public int CategoryId { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;
    
    public DateTime DateChanged { get; set; }
}