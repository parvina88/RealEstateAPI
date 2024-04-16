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

        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var building = await _buildingRepository.GetAsync(id);

            if (building == null)
                return false;

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
            var buildingExist = await _buildingRepository.GetAsync(building.Id, token);

            if (buildingExist == null)
            {
                return false;
            }

            return await _buildingRepository.UpdateAsync(building, token);
        }
    }
}
