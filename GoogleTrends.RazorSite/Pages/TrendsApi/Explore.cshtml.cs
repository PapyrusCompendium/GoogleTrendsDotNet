using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using GoogleTrends.Models.Explore;
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Widgets;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleTrends.RazorSite.Pages.TrendsApi {
    public class ExploreModel : PageModel {
        [BindProperty]
        public string SearchQuery { get; set; }

        public ExploreResponse ExploreResponse { get; set; }
        public RankedList[] RelatedQueries { get; set; }
        public RankedList[] RelatedTopics { get; set; }
        public GeoMapData[] GeoMapData { get; set; }
        public TimelineData[] TimeLineData { get; set; }

        private readonly IGoogleTrendsClient _googleTrendsClient;

        public ExploreModel(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task<IActionResult> OnPostAsync() {
            ExploreResponse = await _googleTrendsClient.Explore.ExploreQuery(SearchQuery, SearchType.WebSearch, untilTime: QueryTimes.Day, geo: RegionIds.Canada);

            var relatedQueriesWidget = ExploreResponse.GetWidgetType(WidgetType.RelatedQueries);
            RelatedQueries = await _googleTrendsClient.Widgets.GetRelatedQueriesWidget(relatedQueriesWidget);

            var relatedTopicsWidget = ExploreResponse.GetWidgetType(WidgetType.RelatedTopics);
            RelatedTopics = await _googleTrendsClient.Widgets.GetRelatedQueriesWidget(relatedTopicsWidget);

            var geoWidget = ExploreResponse.GetWidgetType(WidgetType.GeoTrend);
            GeoMapData = await _googleTrendsClient.Widgets.GetGeoDataWidget(geoWidget);

            var timelineWidget = ExploreResponse.GetWidgetType(WidgetType.TimelineTrend);
            TimeLineData = await _googleTrendsClient.Widgets.GetTimelineWidget(timelineWidget);

            return Page();
        }
    }
}
