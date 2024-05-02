using Contracts.Requests;
using Contracts.Responses;
using RealEstate.Client.Services.HttpClients;
using System.Net.Http;

namespace RealEstate.Client.Services.Building
{
    public class BuildingService : IBuildingService
    {

        private readonly IHttpClientService _httpClient;
        private readonly IConfiguration _configuration;

        public BuildingService(IHttpClientService httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<ApiResponse<GetAllBuildingsResponse>> GetAllAsync(GetAllBuildingsRequest request)
        {
            return await _httpClient.GetJsonAsync<GetAllBuildingsResponse>("https://localhost:7231/Building/api/buildings", request);
        }

    }
}
