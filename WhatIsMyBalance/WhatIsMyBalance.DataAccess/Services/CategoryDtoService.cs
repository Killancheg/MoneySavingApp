using Microsoft.EntityFrameworkCore;
using WhatIsMyBalance.DataAccess.ModelsDA;

namespace WhatIsMyBalance.DataAccess.Services;

public class CategoryDtoService : BaseModelService<CategoryDto>, ICategoryDtoService
{
    protected CategoryDtoService(DataContext context) 
        : base(context)
    {
    }
}