using Application.Common.Exceptions;
using Application.Logging;
using Application.Logic;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Persistence.Repositories.Logic
{
    public class CallAPI : ICallApi
    {
        private readonly ILoggerManager _logger;

        protected HttpClient _client = new HttpClient();
        private string _baseUrl = "";

        public CallAPI(HttpClient client, string baseUrl, ILoggerManager logger)
        {
            _client = client;
            _baseUrl = baseUrl;
            _logger = logger;
        }

        public void SetAuthenticationHeaderValue(string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public void SetTokenHeaderValue(string value)
        {
            _client.DefaultRequestHeaders.Add("Token", value);
        }

        public async Task<T> GetData<T>(string url)
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl + url);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(responseContent);
                }
                else
                {
                    throw new HttpStatusException($"Error, url: {_baseUrl}, statusCode: {response.StatusCode}, responseContent: {responseContent}");
                }
            }
            catch (Exception ex)
            {
                throw new HttpStatusException($"{ex.Message}");
            }
        }
    }
}
