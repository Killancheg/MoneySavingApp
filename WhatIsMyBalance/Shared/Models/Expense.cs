namespace WhatIsMyBalance.Shared.Models;

public class Expense
{
    public int Id { get; set; }

    public decimal Amount { get; set; }
    
    public string Description { get; set; }
    
    public Wallet Wallet { get; set; }
    
    public int WalletId { get; set; }
    
    public ExpenseCategory Category { get; set; }
    
    public int CategoryId { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;
    
    public DateTime DateChanged { get; set; }
}