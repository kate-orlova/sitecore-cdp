using Newtonsoft.Json;

namespace FullStackExperience.Models.Api
{
    public class FlowExecutionResult
    {
        [JsonProperty("guestEmail")]
        public string GuestEmail { get; set; }

        [JsonProperty("guestName")]
        public string GuestName { get; set; }

        [JsonProperty("contentItemId")]
        public string ContentItemId { get; set; }
    }
}
