using System.Web.Mvc;
using Foundation.SitecoreCDP.Configuration;
using FullStackExperience.Models;
using FullStackExperience.Services;
using Sitecore.Data;

namespace FullStackExperience.Controllers
{
    public class BannerController : Controller
    {
        private readonly FlowExecutionService _flowExecutionService;

        public BannerController(FlowExecutionService flowExecutionService)
        {
            _flowExecutionService = flowExecutionService;
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
            var model = new BannerModel()
            {
                GuestEmail = result?.GuestEmail,
                GuestName = result?.GuestName
            };

            if (result != null && ID.TryParse(result.ContentItemId, out var id))
            {
                model.ContentItem = Sitecore.Context.Database.GetItem(id);
            }

            return View("~/Views/FullStackExperience/Banner.cshtml", model);
        }
    }
}
