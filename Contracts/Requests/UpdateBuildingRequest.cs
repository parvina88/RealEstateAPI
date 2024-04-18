using Domain.Enum;
using System.Text.Json.Serialization;

namespace Contracts.Requests;

public record class UpdateBuildingRequest
{
    [JsonIgnore] public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int EntrancesCount { get; set; }
    public double CeilingHeight { get; set; }
    public bool RestSector { get; set; }
    public bool HasLift { get; set; }
    public BuildingMaterial Material { get; set; }
    public BuildingClass BuildingClass { get; set; }
}