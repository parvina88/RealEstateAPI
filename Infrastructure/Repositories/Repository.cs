namespace Domain.Interfaces.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
