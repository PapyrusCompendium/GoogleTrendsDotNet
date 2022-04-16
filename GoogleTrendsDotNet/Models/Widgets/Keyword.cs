
using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class Keyword {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
