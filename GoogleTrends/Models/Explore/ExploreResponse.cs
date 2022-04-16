using System.Collections.Generic;

using GoogleTrends.Models.RelatedQueries.Request;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore {
    public class ExploreResponse {
        [JsonProperty("widgets")]
        public List<Widget> Widgets { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("timeRanges")]
        public List<string> TimeRanges { get; set; }

        [JsonProperty("examples")]
        public List<object> Examples { get; set; }

        [JsonProperty("shareText")]
        public string ShareText { get; set; }

        [JsonProperty("shouldShowMultiHeatMapMessage")]
        public bool ShouldShowMultiHeatMapMessage { get; set; }
    }
}
