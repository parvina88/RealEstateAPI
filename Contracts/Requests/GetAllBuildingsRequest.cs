using Domain.Entities;

namespace Contracts.Requests;

public record class GetAllBuildingsRequest
{
    public IEnumerable<Building> Items { get; init; } = Enumerable.Empty<Building>();

}