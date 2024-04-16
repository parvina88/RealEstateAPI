using Domain.Entities;

namespace Contracts.Requests
{
    public class GetAllBuildingsRequest
    {
        public IEnumerable<Building> Items { get; set; } = Enumerable.Empty<Building>();

    }
}
