namespace WhatIsMyBalance.DataAccess.ModelsDA;

public class CategoryDto
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public bool IsIncome { get; set; }
    
    public int IconId { get; set; }
    
    public int UserId { get; set; }
}