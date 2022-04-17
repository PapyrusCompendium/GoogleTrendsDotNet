
using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class RelatedQuery {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("exploreLink")]
        public string ExploreLink { get; set; }
    }
}
