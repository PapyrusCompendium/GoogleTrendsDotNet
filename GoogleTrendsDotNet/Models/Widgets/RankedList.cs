using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class RankedList {
        [JsonProperty("rankedKeyword")]
        public List<RankedKeyword> RankedKeywords { get; set; }
    }
}
