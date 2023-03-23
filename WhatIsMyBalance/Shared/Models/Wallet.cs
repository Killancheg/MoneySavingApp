namespace WhatIsMyBalance.Shared.Models;

public class Wallet
{
    private int Id { get; set; }
    
    private decimal TotalCredits { get; set; }
    
    private string CurrencyType { get; set; }

    private int UserId { get; set; }
}