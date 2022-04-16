
using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries.Request {
    public class Keyword {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
