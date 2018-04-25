using Newtonsoft.Json;

namespace ClashSharp.Data
{
    public class Member
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("townhallLevel")]
        public long TownhallLevel { get; set; }

        [JsonProperty("mapPosition")]
        public long MapPosition { get; set; }

        [JsonProperty("attacks", NullValueHandling = NullValueHandling.Ignore)]
        public Attack[] Attacks { get; set; }

        [JsonProperty("opponentAttacks")]
        public long OpponentAttacks { get; set; }

        [JsonProperty("bestOpponentAttack", NullValueHandling = NullValueHandling.Ignore)]
        public Attack BestOpponentAttack { get; set; }
    }
}
