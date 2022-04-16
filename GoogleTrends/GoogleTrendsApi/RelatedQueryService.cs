using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.RelatedQueries;

namespace GoogleTrends.GoogleTrendsApi {
    public class RelatedQueryService {
        private const string RELATED_SEARCHES = "widgetdata/relatedsearches";

        private readonly GoogleTrendsClient _googleTrendsClient;

        public RelatedQueryService(GoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task<object> FindRelatedQueries(string query) {
            return await FindRelatedQueries(new RelatedQueryParameters {
                Query = query,
                Region = Regions.UnitedStates
            });
        }

        public async Task<object> FindRelatedQueries(RelatedQueryParameters relatedQueryParameters) {
            var parameters = AddDefaultParameters(relatedQueryParameters);

            var requestUri = new UriBuilder(RELATED_SEARCHES) {
                Query = parameters.ToString()
            };
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, requestUri.Uri);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<>();
        }

        private static NameValueCollection AddDefaultParameters(ApiParameter apiParameter) {
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            parameters["hl"] = apiParameter.Region;
            parameters["tz"] = apiParameter.TimeZone.ToString();
            parameters["token"] = apiParameter.Token;
            return parameters;
        }
    }
}