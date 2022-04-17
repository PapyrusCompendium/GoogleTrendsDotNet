using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class RealTimeTrends {
        [JsonProperty("featuredStoryIds")]
        public List<string> FeaturedStoryIds { get; set; }

        [JsonProperty("trendingStoryIds")]
        public List<string> TrendingStoryIds { get; set; }

        [JsonProperty("storySummaries")]
        public StorySummaries StorySummaries { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("hideAllImages")]
        public bool HideAllImages { get; set; }
    }
}
