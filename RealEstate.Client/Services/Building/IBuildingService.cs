using Contracts.Requests;
using Contracts.Responses;

namespace RealEstate.Client.Services.Building
{
    public interface IBuildingService
    {
        Task <ApiResponse<GetAllBuildingsResponse>> GetAllAsync (GetAllBuildingsRequest request);

            
    }
}
