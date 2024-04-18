namespace Contracts.Responses;

public record class GetAllBuildingsResponse
{
    public IEnumerable<SingleBuildingResponse> Items { get; init; } = Enumerable.Empty<SingleBuildingResponse>();
}