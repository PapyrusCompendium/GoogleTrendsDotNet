
using Newtonsoft.Json;

namespace GoogleTrends.Models.Request {
    public class TrendinessSettings {
        [JsonProperty("compareTime")]
        public string CompareTime { get; set; }
    }
}
