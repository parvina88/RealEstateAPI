using System.Net.Http.Json;


namespace RealEstate.Client.Services.HttpClients
{
    public class HttpClientService(IHttpClientFactory httpClientFactory) : IHttpClientService
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

        public async Task<ApiResponse<T>> GetJsonAsync<T>(string url, object content)
        {
            try
            {
                using var _httpClient = await CreateHttpClient();
                var responseContent = await _httpClient.GetFromJsonAsync<T>(url, content);
                return ApiResponse<T>.BuildSuccess(responseContent);
            }
            catch (HttpRequestException ex)
            {
                return ApiResponse<T>.BuildFailed($"Server is not responding. {ex.Message}", ex.StatusCode);
            }
        }

        public async Task<ApiResponse> DeleteAsync(string url)
        {
            try
            {
                using var _httpClient = await CreateHttpClient();
                var response = await _httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                    return ApiResponse.BuildSuccess();
                return ApiResponse.BuildFailed("Error on sending response. Please try again later", response.StatusCode);
            }
            catch (HttpRequestException ex)
            {
                return ApiResponse.BuildFailed($"Server is not responding. {ex.Message}", ex.StatusCode);
            }
        }

        public async Task<ApiResponse<T>> PostJsonAsync<T>(string url, object content)
        {
            try
            {
                using var _httpClient = await CreateHttpClient();
                var response = await _httpClient.PostAsJsonAsync(url, content);
                return await GetApiResponseAsync<T>(response);
            }
            catch (HttpRequestException ex)
            {
                return ApiResponse<T>.BuildFailed($"Server is not responding. {ex.Message}", ex.StatusCode);
            }
        }

        public async Task<ApiResponse<T>> GetApiResponseAsync<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadFromJsonAsync<T>();
                return ApiResponse<T>.BuildSuccess(responseContent);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                ErrorResponse responseContent = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                return ApiResponse<T>.BuildFailed(responseContent, response.StatusCode);
            }
            return ApiResponse<T>.BuildFailed("Error on sending response. Please try again later", response.StatusCode);
        }

        public async Task<ApiResponse<T>> PutJsonAsync<T>(string url, object content)
        {
            try
            {
                using var _httpClient = await CreateHttpClient();
                var response = await _httpClient.PutAsJsonAsync(url, content);
                return await GetApiResponseAsync<T>(response);
            }
            catch (HttpRequestException ex)
            {
                return ApiResponse<T>.BuildFailed($"Server is not responding. {ex.Message}", ex.StatusCode);
            }
        }

        private async Task<HttpClient> CreateHttpClient()
        {
            return _httpClientFactory.CreateClient();
        }
    }
}