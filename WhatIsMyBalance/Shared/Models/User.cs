namespace WhatIsMyBalance.Shared.Models;

public class User
{
    public int Id { get; set; }
    
    public string Username { get; set; }
    
    public byte[] Password { get; set; }
}