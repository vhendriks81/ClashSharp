using Newtonsoft.Json;

namespace ClashSharp.Data
{
    public class Clan
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }

        [JsonProperty("clanLevel")]
        public long ClanLevel { get; set; }

        [JsonProperty("attacks")]
        public long Attacks { get; set; }

        [JsonProperty("stars")]
        public long Stars { get; set; }

        [JsonProperty("destructionPercentage")]
        public double DestructionPercentage { get; set; }

        [JsonProperty("members")]
        public Member[] Members { get; set; }
    }
}
