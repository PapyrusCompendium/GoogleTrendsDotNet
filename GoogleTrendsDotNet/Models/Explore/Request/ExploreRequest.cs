using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore.Request {
    public class ExploreRequest {
        [JsonProperty("comparisonItem")]
        public List<ComparisonItem> ComparisonItem { get; set; }

        [JsonProperty("category")]
        public int Category { get; set; }

        [JsonProperty("property")]
        public string SearchType { get; set; }

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}
