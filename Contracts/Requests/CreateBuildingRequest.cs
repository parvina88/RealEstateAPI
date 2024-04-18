using Domain.Enum;

namespace Contracts.Requests
{
    public record CreateBuildingRequest //DTO 
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int EntrancesCount { get; set; }
        public double CeilingHeight { get; set; }
        public bool RestSector { get; set; }
        public bool HasLift { get; set; }
        public BuildingMaterial Material { get; set; }
        public BuildingClass BuildingClass { get; set; }
    }
}
