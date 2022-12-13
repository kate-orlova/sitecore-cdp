using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Foundation.SitecoreCDP.Configuration;
using FullStackExperience.Models;
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

        public FlowExecutionResult ExecuteFlow(FlowExecutionRequest request)
        {
            var result = ExecuteFlowAsync(request).GetAwaiter().GetResult();
            return result;
        }

        public async Task<FlowExecutionResult> ExecuteFlowAsync(FlowExecutionRequest request)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var httpResponse = await _httpClient.PostAsync("callFlows", content);
            httpResponse.EnsureSuccessStatusCode();

            try
            {
                return await httpResponse.Content.ReadAsAsync<FlowExecutionResult>();
            }
            catch
            {
                //add logging
            }

            return null;
        }
    }
}