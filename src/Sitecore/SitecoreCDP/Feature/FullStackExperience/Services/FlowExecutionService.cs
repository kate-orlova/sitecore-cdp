using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
            _httpClient.BaseAddress = new Uri("https://api.boxever.com/v2/");

        }

        public FlowExecutionResult ExecuteFlow(FlowExecutionRequest request)
        {
            var response = ExecuteFlowAsync(request).GetAwaiter().GetResult();
            var responseContent = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var flowExecutionResult = JsonConvert.DeserializeObject<FlowExecutionResult>(responseContent);
            return flowExecutionResult;
        }

        public async Task<HttpResponseMessage> ExecuteFlowAsync(FlowExecutionRequest request)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            return await _httpClient.PostAsync("callFlows", content);


        }
    }
}