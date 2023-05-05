using Microsoft.AspNetCore.Components;
using WhatIsMyBalance.Client.Authentication;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Client.Pages.Authentication;

public partial class Register
{
    private string _error;
    
    private RegisterRequest RegisterRequest { get; set; }
    
    [Inject] 
    private NavigationManager NavManager { get; set; }
    
    [Inject]
    private CustomStateProvider AuthStateProvider { get; set; }
    
    async Task OnSubmit()
    {
        _error = null;
        try
        {
            await AuthStateProvider.Register(RegisterRequest);
            NavManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            _error = ex.Message;
        }
    }
}