using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class DailyTrends {
        [JsonProperty("trendingSearchesDays")]
        public List<TrendingSearchesDay> TrendingSearchesDays { get; set; }

        [JsonProperty("endDateForNextRequest")]
        public string EndDateForNextRequest { get; set; }

        [JsonProperty("rssFeedPageUrl")]
        public string RssFeedPageUrl { get; set; }
    }
}
