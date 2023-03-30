using System.ComponentModel.DataAnnotations.Schema;

namespace WhatIsMyBalance.DataAccess.ModelsDA;

public class WalletDto
{
    public int Id { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalCredits { get; set; }
    
    public string CurrencyType { get; set; }
    
    public IEnumerable<BalanceChangeDto> BalanceChanges { get; set; }

    public int UserId { get; set; }
}