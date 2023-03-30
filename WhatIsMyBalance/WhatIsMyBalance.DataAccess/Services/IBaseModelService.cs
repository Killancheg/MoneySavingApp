namespace WhatIsMyBalance.DataAccess.Services;

public interface IBaseModelService<T>
    where T: class
{
    Task CreateAsync(T? model, bool saveChanges = true);

    Task CreateManyAsync(IEnumerable<T?> models, bool saveChanges = true);

    Task<IEnumerable<T?>> ListAsync();

    Task<T?> GetByIdAsync(int id);

    Task DeleteByIdAsync(int id, bool saveChanges = true);

    Task DeleteAsync(T model, bool saveChanges = true);

    Task DeleteRangeAsync(IEnumerable<T> entities, bool saveChanges = true);

    Task<bool> ExistsAsync(int id);
}