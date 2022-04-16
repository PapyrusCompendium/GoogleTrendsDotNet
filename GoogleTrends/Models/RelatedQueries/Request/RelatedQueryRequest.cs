using System.Collections.Generic;

using GoogleTrends.Models.Request;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries.Request {
    public class RelatedQueryRequest {
        [JsonProperty("restriction")]
        public Restriction Restriction { get; set; }

        [JsonProperty("keywordType")]
        public string KeywordType { get; set; }

        [JsonProperty("metric")]
        public List<string> Metric { get; set; }

        [JsonProperty("trendinessSettings")]
        public TrendinessSettings TrendinessSettings { get; set; }

        [JsonProperty("requestOptions")]
        public RequestOptions RequestOptions { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("userCountryCode")]
        public string UserCountryCode { get; set; }

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}
