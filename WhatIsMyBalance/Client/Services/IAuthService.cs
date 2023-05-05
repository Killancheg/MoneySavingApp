using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Services;

public interface IAuthService
{
    Task LoginAsync(LoginRequest loginRequest);
    Task RegisterAsync(RegisterRequest registerRequest);
    Task LogoutAsync();
    Task<CurrentUser> CurrentUserInfoAsync();
}