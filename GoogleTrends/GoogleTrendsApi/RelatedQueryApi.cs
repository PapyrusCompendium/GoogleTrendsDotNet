using System;
using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.RelatedQueries;
using GoogleTrends.Models.RelatedQueries.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public class RelatedQueryApi : ApiService {
        private const string RELATED_SEARCHES = "api/widgetdata/relatedsearches";

        public RelatedQueryApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<RelatedQueriesResponse> FindRelatedQueries(RelatedQueryRequest query) {
            return await FindRelatedQueries(new RelatedQueryParameters {
                Query = query,
                Region = Regions.UnitedStates
            });
        }

        public async Task<RelatedQueriesResponse> FindRelatedQueries(RelatedQueryParameters relatedQueryParameters) {
            var parameters = AddDefaultParameters(relatedQueryParameters);
            parameters["req"] = relatedQueryParameters.Query.ToString();

            var uriString = $"{RELATED_SEARCHES}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<RelatedQueriesResponse>("default");
        }
    }
}