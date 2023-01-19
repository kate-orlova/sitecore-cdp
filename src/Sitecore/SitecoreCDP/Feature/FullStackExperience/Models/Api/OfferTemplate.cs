using Newtonsoft.Json;

namespace FullStackExperience.Models.Api
{
    public class OfferTemplate
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}