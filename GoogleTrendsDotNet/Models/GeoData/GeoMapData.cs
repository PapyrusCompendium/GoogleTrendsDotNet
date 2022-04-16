using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.GeoData {
    public class GeoMapData {
        [JsonProperty("geoCode")]
        public string GeoCode { get; set; }

        [JsonProperty("geoName")]
        public string GeoName { get; set; }

        [JsonProperty("value")]
        public List<int> Value { get; set; }

        [JsonProperty("formattedValue")]
        public List<string> FormattedValue { get; set; }

        [JsonProperty("maxValueIndex")]
        public int MaxValueIndex { get; set; }

        [JsonProperty("hasData")]
        public List<bool> HasData { get; set; }
    }
}
