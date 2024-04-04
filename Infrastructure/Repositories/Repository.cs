namespace Domain.Interfaces.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
