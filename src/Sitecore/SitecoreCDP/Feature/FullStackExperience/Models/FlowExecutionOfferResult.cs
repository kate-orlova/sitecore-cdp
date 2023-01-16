using Newtonsoft.Json;

namespace FullStackExperience.Models
{
    public class FlowExecutionOfferResult
    {
        [JsonProperty("guestEmail")]
        public string GuestEmail { get; set; }

        [JsonProperty("guestName")]
        public string GuestName { get; set; }

        [JsonProperty("offer")]
        public BannerOfferTemplate Offer { get; set; }
    }
}
