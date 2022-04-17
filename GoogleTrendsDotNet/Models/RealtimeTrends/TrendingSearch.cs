using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class TrendingSearch {
        [JsonProperty("title")]
        public Title Title { get; set; }

        [JsonProperty("formattedTraffic")]
        public string FormattedTraffic { get; set; }

        [JsonProperty("relatedQueries")]
        public List<RelatedQuery> RelatedQueries { get; set; }

        [JsonProperty("image")]
        public ImageData Image { get; set; }

        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }

        [JsonProperty("shareUrl")]
        public string ShareUrl { get; set; }
    }
}
