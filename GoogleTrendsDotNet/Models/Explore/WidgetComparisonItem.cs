
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Widgets;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore {
    public class WidgetComparisonItem {
        [JsonProperty("geo")]
        public GeoCountry Geo { get; set; }

        [JsonProperty("complexKeywordsRestriction")]
        public ComplexKeywordsRestriction ComplexKeywordsRestriction { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
