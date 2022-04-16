using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries {
    public class RankedList {
        [JsonProperty("rankedKeyword")]
        public List<RankedKeyword> RankedKeywords { get; set; }
    }
}
