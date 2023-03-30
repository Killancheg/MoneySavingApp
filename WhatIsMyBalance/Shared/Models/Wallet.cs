using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhatIsMyBalance.Shared.Models;

public class Wallet
{
    public int Id { get; set; }
    
    public decimal TotalCredits { get; set; }
    
    public string CurrencyType { get; set; }
    
    public IEnumerable<BalanceChange> BalanceChanges { get; set; }

    public int UserId { get; set; }
}