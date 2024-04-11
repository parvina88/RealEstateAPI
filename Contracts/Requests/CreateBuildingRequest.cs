using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreateBuildingRequest
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
