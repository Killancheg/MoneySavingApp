﻿using System.Net.Http.Json;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    
    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<CurrentUser> CurrentUserInfoAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<CurrentUser>("api/Auth/CurrentUserInfo");
        return result;
    }
    
    public async Task LoginAsync(LoginRequest loginRequest)
    {
        var result = await _httpClient.PostAsJsonAsync("api/Auth/Login", loginRequest);
        
        if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
        {
            throw new Exception(await result.Content.ReadAsStringAsync());
        }
        
        result.EnsureSuccessStatusCode();
    }
    
    public async Task LogoutAsync()
    {
        var result = await _httpClient.PostAsync("api/Auth/Logout", null);
        
        result.EnsureSuccessStatusCode();
    }
    
    public async Task RegisterAsync(RegisterRequest registerRequest)
    {
        var result = await _httpClient.PostAsJsonAsync("api/auth/Register", registerRequest);
        
        if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
        {
            throw new Exception(await result.Content.ReadAsStringAsync());
        }
        
        result.EnsureSuccessStatusCode();
    }
}