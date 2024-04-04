using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly IApplicationDbContext _context;

        public BuildingRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Building> CreateAsync(Building building, CancellationToken token = default)
        {
            await _context.Buildings.AddAsync(building, token);
            return building;
        }

        public async Task<bool> DeleteAsync(Building building, CancellationToken token = default)
        {
            _context.Buildings.Remove(building);
            return await _context.SaveChangesAsync(token) > 0;

        }

        public async Task<IEnumerable<Building>> GetAllAsync(CancellationToken token = default)
        {
            return await _context.Buildings.ToListAsync(token);
        }

        public async Task<Building> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _context.Buildings.FirstOrDefaultAsync(b => b.Id == id, token);
        }

        public async Task<Building> GetByNameAsync(string name)
        {
            return await _context.Buildings.FirstOrDefaultAsync(b => b.Name == name);
        }

        public async Task<bool> UpdateAsync(Building building, CancellationToken token = default)
        {
            _context.Buildings.Update(building);
            return await _context.SaveChangesAsync(token) > 0;
        }
    }
}
