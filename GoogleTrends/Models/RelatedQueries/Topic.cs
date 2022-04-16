﻿using Newtonsoft.Json;

namespace GoogleTrends.Models.RelatedQueries {
    public class Topic {
        [JsonProperty("mid")]
        public string Mid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
