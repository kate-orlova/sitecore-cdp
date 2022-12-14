using System;
using System.Net.Http;
using Foundation.SitecoreCDP.Configuration;
using FullStackExperience.Models;

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
            /*var httpResponse = _httpClient.PostAsJsonAsync("callFlows", request).Result;
            httpResponse.EnsureSuccessStatusCode();

            try
            {
                return httpResponse.Content.ReadAsAsync<FlowExecutionResult>().Result;
            }
            catch
            {
                //add logging
            }*/

            return null;
        }
    }
}