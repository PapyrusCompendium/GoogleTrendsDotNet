using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class StorySummaries {
        [JsonProperty("featuredStories")]
        public List<GoogleTrendsStory> FeaturedStories { get; set; }

        [JsonProperty("trendingStories")]
        public List<GoogleTrendsStory> TrendingStories { get; set; }
    }
}
