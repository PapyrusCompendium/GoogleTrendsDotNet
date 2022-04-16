using System.Collections.Generic;

using GoogleTrends.Models.Explore;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class Widget {
        [JsonProperty("request")]
        public WidgetRequest Request { get; set; }

        [JsonProperty("lineAnnotationText")]
        public string LineAnnotationText { get; set; }

        [JsonProperty("bullets")]
        public List<Bullet> Bullets { get; set; }

        [JsonProperty("showLegend")]
        public bool ShowLegend { get; set; }

        [JsonProperty("showAverages")]
        public bool ShowAverages { get; set; }

        [JsonProperty("helpDialog")]
        public HelpDialog HelpDialog { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("embedTemplate")]
        public string EmbedTemplate { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("isLong")]
        public bool IsLong { get; set; }

        [JsonProperty("isCurated")]
        public bool IsCurated { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("searchInterestLabel")]
        public string SearchInterestLabel { get; set; }

        [JsonProperty("displayMode")]
        public string DisplayMode { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("bullet")]
        public string Bullet { get; set; }

        [JsonProperty("keywordName")]
        public string KeywordName { get; set; }
    }
}
