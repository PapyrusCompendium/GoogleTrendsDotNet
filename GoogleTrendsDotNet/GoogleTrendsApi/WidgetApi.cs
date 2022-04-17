using System.Threading.Tasks;

using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.ParameterTypes;
using GoogleTrends.Models.Widgets;

namespace GoogleTrends.GoogleTrendsApi {
    public class WidgetApi : ApiService, IWidgetApi {
        private const string RELATED_SEARCHES_WIDGET = "api/widgetdata/relatedsearches";
        private const string GEO_DATA_WIDGET = "api/widgetdata/comparedgeo";
        private const string TIMELINE_WIDGET = "api/widgetdata/multiline";

        public WidgetApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<RankedList[]> GetRelatedQueriesWidget(Widget widget) {
            return await GetRelatedQueriesWidget(GenerateRequestParameter(widget));
        }

        public async Task<RankedList[]> GetRelatedQueriesWidget(WidgetRequestParameter relatedQueryParameters) {
            return await SendRequest<RankedList[]>(relatedQueryParameters, RELATED_SEARCHES_WIDGET, "$.default.rankedList");
        }

        public async Task<GeoMapData[]> GetGeoDataWidget(Widget widget) {
            return await GetGeoDataWidget(GenerateRequestParameter(widget));
        }

        public async Task<GeoMapData[]> GetGeoDataWidget(WidgetRequestParameter relatedQueryParameters) {
            return await SendRequest<GeoMapData[]>(relatedQueryParameters, GEO_DATA_WIDGET, "$.default.geoMapData");
        }

        public async Task<TimelineData[]> GetTimelineWidget(Widget widget) {
            return await GetTimelineWidget(GenerateRequestParameter(widget));
        }

        public async Task<TimelineData[]> GetTimelineWidget(WidgetRequestParameter relatedQueryParameters) {
            return await SendRequest<TimelineData[]>(relatedQueryParameters, TIMELINE_WIDGET, "$.default.timelineData");
        }

        private WidgetRequestParameter GenerateRequestParameter(Widget widget, UserRegion region = default) {
            return new WidgetRequestParameter {
                Query = widget.Request,
                Region = region,
                Token = widget.Token
            };
        }
    }
}