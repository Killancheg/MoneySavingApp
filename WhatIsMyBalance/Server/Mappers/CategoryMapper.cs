using Riok.Mapperly.Abstractions;
using WhatIsMyBalance.DataAccess.ModelsDA;
using WhatIsMyBalance.Shared.Models;

namespace WhatIsMyBalance.Server.Mappers;

[Mapper]
public partial class CategoryMapper
{
    public partial CategoryDto CategoryToCategoryDto(Category category);
    
    public partial IEnumerable<CategoryDto> CategoriesToCategoriesDto(IEnumerable<Category> categories);
    
    public partial Category CategoryDtoToCategory(CategoryDto category);

    public partial IEnumerable<Category> CategoriesDtoToCategories(IEnumerable<CategoryDto> categoriesDto);
}