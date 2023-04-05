using Riok.Mapperly.Abstractions;
using WhatIsMyBalance.DataAccess.ModelsDA;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Mappers;

[Mapper]
public partial class BalanceChangeMapper
{
    public partial BalanceChangeDto BalanceChangeToBalanceChangeDto(BalanceChange balanceChange);
    
    public partial IEnumerable<BalanceChangeDto> BalanceChangesToBalanceChangesDto(IEnumerable<BalanceChange> balanceChanges);
    
    public partial BalanceChange BalanceChangeDtoToBalanceChange(BalanceChangeDto balanceChangeDto);

    public partial IEnumerable<BalanceChange> BalanceChangesDtoToBalanceChanges(IEnumerable<BalanceChangeDto> balanceChangesDto);
}