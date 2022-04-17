using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public class ExploreApi : ApiService, IExploreApi {
        private const string EXPLORE = "api/explore";

        public ExploreApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<ExploreResponse> ExploreQuery(string query, string searchType = default,
            string userRegion = default, string queryTime = "now 4-H", string geoSearch = default) {
            return await ExploreQuery(new ExploreQueryParameters {
                Region = string.IsNullOrWhiteSpace(userRegion) ? Regions.UnitedStates : userRegion,
                Request = new() {
                    Category = 0,
                    SearchType = string.IsNullOrWhiteSpace(searchType) ? SearchType.WebSearch : searchType,
                    ComparisonItem = new() {
                        new() {
                            Geo = geoSearch,
                            Time = queryTime,
                            Keyword = query
                        }
                    }
                }
            });
        }

        public async Task<ExploreResponse> ExploreQuery(ExploreQueryParameters exploreQueryParameters) {
            var exploreResponse = await SendRequest<ExploreResponse>(exploreQueryParameters, EXPLORE);
            exploreResponse.GoogleTrendsClient = _googleTrendsClient;
            return exploreResponse;
        }
    }
}
