namespace WhatIsMyBalance.DataAccess.ModelsDA;

public class UserDto
{
    public int Id { get; set; }
    
    public string Username { get; set; }
    
    public byte[] Password { get; set; }
}