using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries.Request {
    public class ComplexKeywordsRestriction {
        [JsonProperty("keyword")]
        public List<Keyword> Keyword { get; set; }
    }
}
