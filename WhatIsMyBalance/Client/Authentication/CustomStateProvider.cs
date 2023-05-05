using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using WhatIsMyBalance.Client.Services;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Authentication;

public class CustomStateProvider : AuthenticationStateProvider
{
    private readonly IAuthService _api;
    
    private CurrentUser _currentUser;
    
    public CustomStateProvider(IAuthService api)
    {
        _api = api;
    }
    
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity();
        
        try
        {
            var userInfo = await GetCurrentUser();
            if (userInfo.IsAuthenticated)
            {
                var claims = new[] { new Claim(ClaimTypes.Name, _currentUser.UserName) }.
                    Concat(_currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
                
                identity = new ClaimsIdentity(claims, "Server authentication");
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Request failed:" + ex.ToString());
        }
        
        return new AuthenticationState(new ClaimsPrincipal(identity));
    }
    
    private async Task<CurrentUser> GetCurrentUser()
    {
        if (_currentUser != null && _currentUser.IsAuthenticated)
        {
            return _currentUser;
        }
        
        _currentUser = await _api.CurrentUserInfoAsync();
        return _currentUser;
    }
    
    public async Task Logout()
    {
        await _api.LogoutAsync();
        
        _currentUser = null;
        
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
    
    public async Task Login(LoginRequest loginParameters)
    {
        await _api.LoginAsync(loginParameters);
        
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
    
    public async Task Register(RegisterRequest registerParameters)
    {
        await _api.RegisterAsync(registerParameters);
        
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}