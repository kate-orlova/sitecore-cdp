using System.Net.Http;
using System.Web.Mvc;
using Foundation.SitecoreCDP.Configuration;
using FullStackExperience.Models;
using FullStackExperience.Services;

namespace FullStackExperience.Controllers
{
    public class BannerController : Controller
    {
        private readonly FlowExecutionService _flowExecutionService;

        public BannerController()
        {
            _flowExecutionService = new FlowExecutionService(new HttpClient());
        }

        public ActionResult Banner()
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

            var result = _flowExecutionService.ExecuteFlow(request).GetAwaiter().GetResult();

            return View("~/Views/FullStackExperience/Banner.cshtml", result);
        }
    }
}
