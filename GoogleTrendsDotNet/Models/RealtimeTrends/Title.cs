using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class Title {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("exploreLink")]
        public string ExploreLink { get; set; }
    }
}
