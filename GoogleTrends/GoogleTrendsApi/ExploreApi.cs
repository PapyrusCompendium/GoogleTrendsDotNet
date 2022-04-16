using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public class ExploreApi : ApiService {
        private const string EXPLORE = "api/explore";

        public ExploreApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<ExploreResponse> ExploreQuery(string query) {
            return await ExploreQuery(new ExploreQueryParameters {
                Region = Regions.UnitedStates,
                Request = new() {
                    Category = 0,
                    Property = string.Empty,
                    ComparisonItem = new() {
                        new() {
                            Geo = string.Empty,
                            Time = "today 12-m",
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
            System.Console.WriteLine($"RetryAfter: {response.Headers.RetryAfter}");
            return response.As<ExploreResponse>();
        }
    }
}
