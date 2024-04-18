using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class BuildingService(IBaseRepository<Building> buildingRepository) : IBaseService<Building>
{
    public async Task<Building> CreateAsync(Building building, CancellationToken token = default)
    {
        return await buildingRepository.CreateAsync(building, token);
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
    {
        var building = await buildingRepository.GetAsync(id, token);

        if (building == null)
            return false;

        return await buildingRepository.DeleteAsync(building, token);
    }

    public async Task<IEnumerable<Building>> GetAllAsync(CancellationToken token = default)
    {
        return await buildingRepository.GetAllAsync(token);
    }

    public async Task<Building> GetAsync(Guid id, CancellationToken token = default)
    {
        return await buildingRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Building building, CancellationToken token = default)
    {
        var buildingExist = await buildingRepository.GetAsync(building.Id, token);

        if (buildingExist == null)
        {
            return false;
        }

        return await buildingRepository.UpdateAsync(building, token);
    }
}