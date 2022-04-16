using Newtonsoft.Json;

namespace GoogleTrends.Models.GeoData {
    public class GeoCountry {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
