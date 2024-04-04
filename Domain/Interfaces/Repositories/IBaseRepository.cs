namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetAsync(Guid id, CancellationToken token = default);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken token = default);
        Task<T> CreateAsync(T entity, CancellationToken token = default);
        Task<bool> UpdateAsync(T entity, CancellationToken token = default);
        Task<bool> DeleteAsync(T entity, CancellationToken token = default);
    }
}
