
using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore.Request {
    public class ComparisonItem {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
