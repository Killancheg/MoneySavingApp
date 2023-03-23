namespace WhatIsMyBalance.Shared.Models;

public class ExpenseCategory
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int IconId { get; set; }
    
    public int UserId { get; set; }
}