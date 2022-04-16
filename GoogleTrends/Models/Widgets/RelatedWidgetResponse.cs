using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class RelatedWidgetResponse {
        [JsonProperty("rankedList")]
        public List<RankedList> RankedList { get; set; }
    }
}
