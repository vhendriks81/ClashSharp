using Newtonsoft.Json;

namespace ClashSharp.Data
{
    public class Attack
    {
        [JsonProperty("attackerTag")]
        public string AttackerTag { get; set; }

        [JsonProperty("defenderTag")]
        public string DefenderTag { get; set; }

        [JsonProperty("stars")]
        public long Stars { get; set; }

        [JsonProperty("destructionPercentage")]
        public long DestructionPercentage { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }
    }
}
