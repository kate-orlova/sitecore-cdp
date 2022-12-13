using System;
using Newtonsoft.Json;

namespace FullStackExperience.Models
{
    public class FlowExecutionResult
    {
        [JsonProperty("guestEmail")]
        public string GuestEmail { get; set; }

        [JsonProperty("guestName")]
        public string GuestName { get; set; }

        [JsonProperty("contentItemId")]
        public Guid ContentItemId { get; set; }
    }
}
