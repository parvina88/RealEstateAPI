using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class BuildingService : IBaseService<Building>
    {
        private readonly IBaseRepository<Building> _buildingRepository;

        public BuildingService(IBaseRepository<Building> buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }

        public async Task<Building> CreateAsync(Building building, CancellationToken token = default)
        {
            return await _buildingRepository.CreateAsync(building, token);
        }

        public async Task<bool> DeleteAsync(Building building, CancellationToken token = default)
        {
            return await _buildingRepository.DeleteAsync(building, token);
        }

        public async Task<IEnumerable<Building>> GetAllAsync(CancellationToken token = default)
        {
            return await _buildingRepository.GetAllAsync(token);
        }

        public async Task<Building> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _buildingRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Building building, CancellationToken token = default)
        {
            var existingBuilding = await GetAsync(building.Id);

            if (existingBuilding is null)
            {
                return false;
            }

            existingBuilding.Name = building.Name;
            existingBuilding.Address = building.Address;
            existingBuilding.CeilingHeight = building.CeilingHeight;
            existingBuilding.BuildingClass = building.BuildingClass;
            existingBuilding.EntrancesCount = building.EntrancesCount;
            existingBuilding.Material = building.Material;

            return await _buildingRepository.UpdateAsync(existingBuilding, token);
        }
    }
}
