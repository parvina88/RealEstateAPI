using Domain.Enum;

namespace Contracts.Responses;

public record class SingleBuildingResponse
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public string? Address { get; init; }
    public int EntrancesCount { get; init; }
    public double CeilingHeight { get; init; }
    public bool RestSector { get; init; }
    public bool HasLift { get; init; }
    public BuildingMaterial Material { get; init; }
    public BuildingClass BuildingClass { get; init; }
}