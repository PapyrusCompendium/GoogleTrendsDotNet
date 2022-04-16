using System.Collections.Generic;

using GoogleTrends.Models.Explore;
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Request;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class WidgetRequest {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("comparisonItem")]
        public List<WidgetComparisonItem> ComparisonItem { get; set; }

        [JsonProperty("requestOptions")]
        public RequestOptions RequestOptions { get; set; }

        [JsonProperty("geo")]
        public GeoCountry Geo { get; set; }

        [JsonProperty("restriction")]
        public Restriction Restriction { get; set; }

        [JsonProperty("keywordType")]
        public string KeywordType { get; set; }

        [JsonProperty("metric")]
        public List<string> Metric { get; set; }

        [JsonProperty("trendinessSettings")]
        public TrendinessSettings TrendinessSettings { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("userCountryCode")]
        public string UserCountryCode { get; set; }

        public override string ToString() {
            return JsonConvert.SerializeObject(this, Formatting.None, new JsonSerializerSettings() {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
