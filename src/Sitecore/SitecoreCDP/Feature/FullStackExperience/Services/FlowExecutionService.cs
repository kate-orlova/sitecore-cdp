using System;
using System.Net.Http;
using System.Threading.Tasks;
using Foundation.SitecoreCDP.Configuration;
using FullStackExperience.Models.Api;
using Newtonsoft.Json;

namespace FullStackExperience.Services
{
    public class FlowExecutionService
    {
        private readonly HttpClient _httpClient;

        public FlowExecutionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ConfigSettings.APIEndpoint);

        }

        public async Task<T> ExecuteFlow<T>(FlowExecutionRequest request)
        {
            //make the sync POST request
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, "callFlows"))
            {
                var json = JsonConvert.SerializeObject(request);
                httpRequest.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                using (var response = await _httpClient.SendAsync(httpRequest).ConfigureAwait(false))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<T>(content);
                    return result;
                }
            }
        }
    }
}