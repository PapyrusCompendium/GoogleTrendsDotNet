using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class GoogleTrendsStory {
        [JsonProperty("image")]
        public ImageData Image { get; set; }

        [JsonProperty("shareUrl")]
        public string ShareUrl { get; set; }

        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }

        [JsonProperty("idsForDedup")]
        public List<string> IdsForDedup { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("entityNames")]
        public List<string> EntityNames { get; set; }
    }
}
