using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class RequestOptions {
        [JsonProperty("property")]
        public string Property { get; set; }

        [JsonProperty("backend")]
        public string Backend { get; set; }

        [JsonProperty("category")]
        public int Category { get; set; }
    }
}
