using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class ComplexKeywordsRestriction {
        [JsonProperty("keyword")]
        public List<Keyword> Keyword { get; set; }
    }
}
