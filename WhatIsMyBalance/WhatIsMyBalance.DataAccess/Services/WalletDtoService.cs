using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess.Services;

public class WalletDtoService : BaseModelService<WalletDto>, IWalletDtoService
{
    protected WalletDtoService(DataContext context) : base(context)
    {
    }
}