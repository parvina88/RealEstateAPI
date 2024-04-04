using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IBuildingRepository : IBaseRepository<Building>
    {
        Task<Building> GetByNameAsync(string name);
    }
}
