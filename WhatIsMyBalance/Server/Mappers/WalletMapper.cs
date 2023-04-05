using Riok.Mapperly.Abstractions;
using WhatIsMyBalance.DataAccess.ModelsDA;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Mappers;

[Mapper]
public partial class WalletMapper
{
    public partial WalletDto WalletToWalletDto(Wallet wallet);

    public partial IEnumerable<WalletDto> WalletsToWalletsDto(IEnumerable<Wallet> wallets);
    public partial Wallet WalletDtoToWallet(WalletDto wallet);
    
    public partial IEnumerable<Wallet> WalletsDtoToWallets(IEnumerable<WalletDto> wallets);
}