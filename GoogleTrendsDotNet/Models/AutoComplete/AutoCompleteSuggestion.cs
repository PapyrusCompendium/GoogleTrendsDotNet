using Newtonsoft.Json;

namespace GoogleTrends.Models.AutoComplete {
    public class AutoCompleteSuggestion {
        [JsonProperty("mid")]
        public string Mid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
