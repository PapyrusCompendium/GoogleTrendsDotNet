using System.Collections.Generic;
using System.Linq;

using GoogleTrends.Models.Widgets;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Explore {
    public class ExploreResponse {
        private const string RELATED_QUERIES_ID = "RELATED_QUERIES";
        private const string RELATED_TOPICS_ID = "RELATED_TOPICS";
        private const string GEO_MAP = "GEO_MAP";
        private const string TIME_SERIES = "TIMESERIES";

        [JsonProperty("widgets")]
        public List<Widget> Widgets { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("timeRanges")]
        public List<string> TimeRanges { get; set; }

        [JsonProperty("examples")]
        public List<object> Examples { get; set; }

        [JsonProperty("shareText")]
        public string ShareText { get; set; }

        [JsonProperty("shouldShowMultiHeatMapMessage")]
        public bool ShouldShowMultiHeatMapMessage { get; set; }

        public Widget GetWidgetType(WidgetType widgetType) {
            switch (widgetType) {
                case WidgetType.RelatedQueries:
                    return Widgets.Single(i => i.Id == RELATED_QUERIES_ID);
                case WidgetType.RelatedTopics:
                    return Widgets.Single(i => i.Id == RELATED_TOPICS_ID);
                case WidgetType.GeoTrend:
                    return Widgets.Single(i => i.Id == GEO_MAP);
                case WidgetType.TimelineTrend:
                    return Widgets.Single(i => i.Id == TIME_SERIES);
                default:
                    return default;
            }
        }
    }
}
