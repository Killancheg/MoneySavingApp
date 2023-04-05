using Microsoft.EntityFrameworkCore;

namespace WhatIsMyBalance.DataAccess.Services
{
    public class BaseModelService<T> : IBaseModelService<T>
        where T: class
    {
        private readonly DbContext _context;

        protected DbSet<T> Entities => _context.Set<T>();
    
        protected BaseModelService(DbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T? model, bool saveChanges = true)
        {
            if (model != null) await Entities.AddAsync(model);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }

        public async Task CreateManyAsync(IEnumerable<T?> models, bool saveChanges = true)
        {
            await Entities.AddRangeAsync(models!);
            
            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T?>> ListAsync()
        {
            return await Entities.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await Entities.FindAsync(id);
        }

        public async Task DeleteByIdAsync(int id, bool saveChanges = true)
        {
            var entity = await Entities.FindAsync(id);
            
            if (entity != null) await DeleteAsync(entity);
        }

        public async Task DeleteAsync(T model, bool saveChanges = true)
        {
            Entities.Remove(model);
            
            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
        {
            var enumerable = entities as T[] ?? entities.ToArray();
            
            if (enumerable.Any())
            {
                Entities.RemoveRange(enumerable);
            }
            
            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await Entities.AnyAsync();
        }
    }
}