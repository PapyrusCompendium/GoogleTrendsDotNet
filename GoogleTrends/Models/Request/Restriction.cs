using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.RelatedQueries.Request;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Request {
    public class Restriction {
        [JsonProperty("geo")]
        public GeoCountry Geo { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("originalTimeRangeForExploreUrl")]
        public string OriginalTimeRangeForExploreUrl { get; set; }

        [JsonProperty("complexKeywordsRestriction")]
        public ComplexKeywordsRestriction ComplexKeywordsRestriction { get; set; }
    }
}
