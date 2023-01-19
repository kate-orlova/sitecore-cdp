using Newtonsoft.Json;

namespace FullStackExperience.Models.Api
{
    public class FlowExecutionRequest
    {
        [JsonProperty("clientKey")]
        public string ClientKey { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("pointOfSale")]
        public string PointOfSale { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("friendlyId")]
        public string FriendlyId { get; set; }
}
}
