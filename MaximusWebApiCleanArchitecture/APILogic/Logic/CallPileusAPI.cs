using APILogic.Configuration;
using Application.Common.Exceptions;
using Application.Logging;
using Application.Logic;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace APILogic.Logic
{
    public class CallPileusAPI : ICallApi
    {
        private readonly ILoggerManager _logger;

        protected HttpClient _client = new HttpClient();
        private string _baseUrl;

        public CallPileusAPI(HttpClient client, IOptions<BaseUrlOptions> baseUrlOptions, ILoggerManager logger)
        {
            _client = client;
            _baseUrl = baseUrlOptions.Value.BaseUrls["Pileus"];
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

        public Task<T> PostData<T>(string query, T data)
        {
            throw new NotImplementedException();
        }

        public Task<T> PutData<T>(string query, T data)
        {
            throw new NotImplementedException();
        }

        public Task DeleteData<T>(string query)
        {
            throw new NotImplementedException();
        }
    }
}
