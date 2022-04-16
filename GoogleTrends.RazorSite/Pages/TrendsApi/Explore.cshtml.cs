using System.Linq;
using System.Threading.Tasks;

using GoogleTrends.Models.Explore;
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Widgets;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleTrends.RazorSite.Pages.TrendsApi {
    public class ExploreModel : PageModel {
        private const string RELATED_QUERIES_ID = "RELATED_QUERIES";
        private const string RELATED_TOPICS_ID = "RELATED_TOPICS";
        private const string TIME_SERIES = "TIMESERIES";
        private const string GEO_MAP = "GEO_MAP";

        [BindProperty]
        public string SearchQuery { get; set; }

        public ExploreResponse ExploreResponse { get; set; }
        public RankedList[] RelatedQueriesResponse { get; set; }
        public RankedList[] RelatedTopicsResponse { get; set; }
        public GeoMapData[] GeoMapData { get; set; }
        public TimelineData[] TimeLineData { get; set; }


        private readonly IGoogleTrendsClient _googleTrendsClient;

        public ExploreModel(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task<IActionResult> OnPostAsync() {
            ExploreResponse = await _googleTrendsClient.Explore.ExploreQuery(SearchQuery);

            var relatedQueriesWidget = ExploreResponse.Widgets.FirstOrDefault(i => i.Id == RELATED_QUERIES_ID);
            RelatedQueriesResponse = await _googleTrendsClient.Widgets.GetRelatedQueriesWidget(relatedQueriesWidget);

            var relatedTopicsWidget = ExploreResponse.Widgets.FirstOrDefault(i => i.Id == RELATED_TOPICS_ID);
            RelatedTopicsResponse = await _googleTrendsClient.Widgets.GetRelatedQueriesWidget(relatedTopicsWidget);

            var geoWidget = ExploreResponse.Widgets.FirstOrDefault(i => i.Id == GEO_MAP);
            GeoMapData = await _googleTrendsClient.Widgets.GetGeoDataWidget(geoWidget);

            var timelineWidget = ExploreResponse.Widgets.FirstOrDefault(i => i.Id == TIME_SERIES);
            TimeLineData = await _googleTrendsClient.Widgets.GetTimelineWidget(timelineWidget);
            return Page();
        }
    }
}
