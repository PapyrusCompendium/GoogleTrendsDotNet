
using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class TrendinessSettings {
        [JsonProperty("compareTime")]
        public string CompareTime { get; set; }
    }
}
