using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;
using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.GoogleTrendsApi {
    public class ExploreApi : ApiService, IExploreApi {
        private const string EXPLORE = "api/explore";

        public ExploreApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<ExploreResponse> ExploreQuery(string query, SearchType searchType = default,
            UserRegion userRegion = default, QueryTimes queryTime = default, GeoId geoSearch = default) {
            return await ExploreQuery(new ExploreQueryParameters {
                Region = userRegion,
                Request = new() {
                    Category = 0,
                    SearchType = searchType.GetObject<string>(),
                    ComparisonItem = new() {
                        new() {
                            Geo = geoSearch.GetObject<string>(),
                            Time = queryTime.GetObject<string>(),
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
