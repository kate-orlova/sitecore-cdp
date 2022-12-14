using System.IO;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Foundation.SitecoreCDP.Configuration;
using FullStackExperience.Models;
using FullStackExperience.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace FullStackExperience.Controllers
{
    public class BannerController : Controller
    {
        private readonly FlowExecutionService _flowExecutionService;

        /*public BannerController(FlowExecutionService flowExecutionService)
        {
            _flowExecutionService = flowExecutionService;
        }*/

        public ActionResult Banner()
        {
            var result = TestTask().GetAwaiter().GetResult();

            return View("~/Views/FullStackExperience/Banner.cshtml", result);
        }

        public async Task<FlowExecutionResult> TestTask()
        {
            var request = new FlowExecutionRequest()
            {
                Channel = ConfigSettings.Channel,
                ClientKey = ConfigSettings.ClientKey,
                CurrencyCode = ConfigSettings.Currency,
                Email = Sitecore.Context.User.Profile?.Email,
                FriendlyId = ConfigSettings.ExperienceId,
                Language = Sitecore.Context.Item.Language.Name,
                PointOfSale = ConfigSettings.POS
            };

            var httpClient = new HttpClient();

            //make the sync POST request
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, ConfigSettings.APIEndpoint + "callFlows"))
            {
                var json = JsonConvert.SerializeObject(request);
                httpRequest.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                using (var response = await httpClient.SendAsync(httpRequest).ConfigureAwait(false))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<FlowExecutionResult>(content);
                    return result;
                }
            }
        }
    }
}
