using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries {
    public class RelatedQueriesResponse {
        [JsonProperty("rankedList")]
        public List<RankedList> RankedList { get; set; }
    }
}
