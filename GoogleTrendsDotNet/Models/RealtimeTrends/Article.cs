
using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class Article {
        [JsonProperty("articleTitle")]
        public string ArticleTitle { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }
    }
}
