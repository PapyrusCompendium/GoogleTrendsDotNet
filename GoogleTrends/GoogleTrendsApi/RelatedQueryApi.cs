using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.Widgets;

namespace GoogleTrends.GoogleTrendsApi {
    public class RelatedQueryApi : ApiService {
        private const string RELATED_SEARCHES = "api/widgetdata/relatedsearches";

        public RelatedQueryApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<RelatedWidgetResponse> FindRelatedQueries(WidgetRequest query, string token) {
            return await FindRelatedQueries(new WidgetRequestParameter {
                Query = query,
                Region = Regions.UnitedStates,
                Token = token
            });
        }

        public async Task<RelatedWidgetResponse> FindRelatedQueries(WidgetRequestParameter relatedQueryParameters) {
            var parameters = AddDefaultParameters(relatedQueryParameters);
            parameters["req"] = relatedQueryParameters.Query.ToString();

            var uriString = $"{RELATED_SEARCHES}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<RelatedWidgetResponse>("$.default");
        }
    }
}