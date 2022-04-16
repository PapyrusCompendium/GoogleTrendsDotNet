using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public class ExploreApi : ApiService, IExploreApi {
        private const string EXPLORE = "api/explore";

        public ExploreApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<ExploreResponse> ExploreQuery(string query, string searchType = default,
            string region = default, string queryTime = "now 4-H", string geo = default) {
            return await ExploreQuery(new ExploreQueryParameters {
                Region = string.IsNullOrWhiteSpace(region) ? Regions.UnitedStates : region,
                Request = new() {
                    Category = 0,
                    SearchType = string.IsNullOrWhiteSpace(searchType) ? SearchType.WebSearch : searchType,
                    ComparisonItem = new() {
                        new() {
                            Geo = geo,
                            Time = queryTime,
                            Keyword = query
                        }
                    }
                }
            });
        }

        public async Task<ExploreResponse> ExploreQuery(ExploreQueryParameters exploreQueryParameters) {
            var parameters = AddDefaultParameters(exploreQueryParameters);
            parameters["req"] = exploreQueryParameters.Request.ToString();
            var uriString = $"{EXPLORE}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);
            var exploreResponse = response.As<ExploreResponse>();
            exploreResponse.GoogleTrendsClient = _googleTrendsClient;
            return exploreResponse;
        }
    }
}
