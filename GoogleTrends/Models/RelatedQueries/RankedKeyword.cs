using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries {
    public class RankedKeyword {
        [JsonProperty("topic")]
        public Topic Topic { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("formattedValue")]
        public string FormattedValue { get; set; }

        [JsonProperty("hasData")]
        public bool HasData { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
