using Newtonsoft.Json;

namespace ClashSharp.Data
{
    public class CurrentWarResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("teamSize")]
        public long TeamSize { get; set; }

        [JsonProperty("preparationStartTime")]
        public string PreparationStartTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("clan")]
        public Clan Clan { get; set; }

        [JsonProperty("opponent")]
        public Clan Opponent { get; set; }
    }
}
