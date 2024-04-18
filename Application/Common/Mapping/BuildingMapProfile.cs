using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping;

public class BuildingMapProfile : Profile
{
    public BuildingMapProfile()
    {
        CreateMap<CreateBuildingRequest, Building>();

        CreateMap<Building, SingleBuildingResponse>();

        CreateMap<GetAllBuildingsRequest, GetAllBuildingsResponse>();

        CreateMap<UpdateBuildingRequest, Building>();
    }
}