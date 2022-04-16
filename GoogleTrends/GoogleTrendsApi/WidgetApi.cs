using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.Explore;
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Widgets;

namespace GoogleTrends.GoogleTrendsApi {
    public class WidgetApi : ApiService {
        private const string RELATED_SEARCHES_WIDGET = "api/widgetdata/relatedsearches";
        private const string GEO_DATA_WIDGET = "api/widgetdata/comparedgeo";
        private const string TIMELINE_WIDGET = "api/widgetdata/multiline";

        public WidgetApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<RankedList[]> GetRelatedQueriesWidget(Widget widget) {
            return await GetRelatedQueriesWidget(GenerateRequestParameter(widget));
        }

        public async Task<RankedList[]> GetRelatedQueriesWidget(WidgetRequestParameter relatedQueryParameters) {
            return await SendWidgetRequest<RankedList[]>(relatedQueryParameters, RELATED_SEARCHES_WIDGET, "$.default.rankedList");
        }

        public async Task<GeoMapData[]> GetGeoDataWidget(Widget widget) {
            return await GetGeoDataWidget(GenerateRequestParameter(widget));
        }

        public async Task<GeoMapData[]> GetGeoDataWidget(WidgetRequestParameter relatedQueryParameters) {
            return await SendWidgetRequest<GeoMapData[]>(relatedQueryParameters, GEO_DATA_WIDGET, "$.default.geoMapData");
        }

        public async Task<TimelineData[]> GetTimelineWidget(Widget widget) {
            return await GetTimelineWidget(GenerateRequestParameter(widget));
        }

        public async Task<TimelineData[]> GetTimelineWidget(WidgetRequestParameter relatedQueryParameters) {
            return await SendWidgetRequest<TimelineData[]>(relatedQueryParameters, TIMELINE_WIDGET, "$.default.timelineData");
        }

        private WidgetRequestParameter GenerateRequestParameter(Widget widget, string region = default) {
            return new WidgetRequestParameter {
                Query = widget.Request,
                Region = string.IsNullOrWhiteSpace(region)
                    ? Regions.UnitedStates
                    : region,
                Token = widget.Token
            };
        }

        private async Task<TType> SendWidgetRequest<TType>(WidgetRequestParameter relatedQueryParameters, string apiUri, string jsonPath = "$.default") {
            var parameters = AddDefaultParameters(relatedQueryParameters);
            parameters["req"] = relatedQueryParameters.Query.ToString();

            var uriString = $"{apiUri}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<TType>(jsonPath);
        }
    }
}