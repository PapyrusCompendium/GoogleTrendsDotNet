using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.GeoData {
    public class GeoLocation {
        [JsonProperty("children")]
        public List<GeoLocation> Children { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
