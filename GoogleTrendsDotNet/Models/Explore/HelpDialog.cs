
using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore {
    public class HelpDialog {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
