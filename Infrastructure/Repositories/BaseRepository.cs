using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> CreateAsync(T entity, CancellationToken token = default)
        {
            await _dbSet.AddAsync(entity, token);
            await _context.SaveChangesAsync(token);
            return entity;
        }

        public async Task<bool> DeleteAsync(T entity, CancellationToken token = default)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync(token) > 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken token = default)
        {
            return await _dbSet.ToListAsync(token);
        }

        public async Task<T> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _dbSet.FindAsync(id, token);
        }

        public async Task<bool> UpdateAsync(T entity, CancellationToken token = default)
        {
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync(token) > 0;
        }
    }
}
