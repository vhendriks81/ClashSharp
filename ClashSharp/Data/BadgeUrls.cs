using Newtonsoft.Json;

namespace ClashSharp.Data
{
    public class BadgeUrls
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }
    }
}
