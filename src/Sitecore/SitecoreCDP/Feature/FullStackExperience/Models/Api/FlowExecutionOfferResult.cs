using Newtonsoft.Json;

namespace FullStackExperience.Models.Api
{
    public class FlowExecutionOfferResult
    {
        [JsonProperty("guestEmail")]
        public string GuestEmail { get; set; }

        [JsonProperty("guestName")]
        public string GuestName { get; set; }

        [JsonProperty("offer")]
        public OfferTemplate Offer { get; set; }
    }
}
