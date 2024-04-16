namespace Contracts.Responses
{
    public class GetAllBuildingsResponse
    {
        public IEnumerable<SingleBuildingResponse> Items { get; set; } = Enumerable.Empty<SingleBuildingResponse>();
    }
}
