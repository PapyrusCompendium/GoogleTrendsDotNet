
using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore {
    public class Bullet {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
