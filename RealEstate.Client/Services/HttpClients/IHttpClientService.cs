namespace RealEstate.Client.Services.HttpClients
{
    public interface IHttpClientService
    {
       Task <ApiResponse<T>> GetJsonAsync<T> (string url, object request);
    }
}
