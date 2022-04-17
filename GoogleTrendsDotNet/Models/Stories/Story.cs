using System.Collections.Generic;

using GoogleTrends.Models.Widgets;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Stories {
    public class Story {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("entityNames")]
        public List<string> EntityNames { get; set; }

        [JsonProperty("entityExploreLinks")]
        public List<string> EntityExploreLinks { get; set; }

        [JsonProperty("timeRange")]
        public string TimeRange { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("bannerImgUrl")]
        public string BannerImgUrl { get; set; }

        [JsonProperty("bannerVideoUrl")]
        public string BannerVideoUrl { get; set; }

        [JsonProperty("pageLayout")]
        public string PageLayout { get; set; }

        [JsonProperty("translate")]
        public bool Translate { get; set; }

        [JsonProperty("parentStoryId")]
        public string ParentStoryId { get; set; }

        [JsonProperty("subTitle")]
        public string SubTitle { get; set; }

        [JsonProperty("eventName")]
        public string EventName { get; set; }

        [JsonProperty("colorTheme")]
        public string ColorTheme { get; set; }

        [JsonProperty("widgets")]
        public List<Widget> Widgets { get; set; }

        [JsonProperty("widgetIds")]
        public List<string> WidgetIds { get; set; }

        [JsonProperty("components")]
        public List<object> Components { get; set; }
    }
}
