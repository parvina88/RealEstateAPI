using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(Guid id);
        IEnumerable<T> GetAll();
    }
}
