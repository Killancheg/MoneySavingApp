using Microsoft.AspNetCore.Components;
using WhatIsMyBalance.Client.Authentication;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Pages.Authentication;

public partial class Login
{
    private string _error;
    
    private LoginRequest LoginRequest { get; set; } = new LoginRequest();
    
    [Inject] 
    private NavigationManager NavManager { get; set; }
    
    [Inject]
    private CustomStateProvider AuthStateProvider { get; set; }
    
    async Task OnSubmit()
    {
        _error = null;
        try
        {
            await AuthStateProvider.Login(LoginRequest);
            NavManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            _error = ex.Message;
        }
    }
}