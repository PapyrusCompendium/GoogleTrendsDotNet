using System.Threading.Tasks;

using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IExploreApi {
        Task<ExploreResponse> ExploreQuery(ExploreQueryParameters exploreQueryParameters);
        Task<ExploreResponse> ExploreQuery(string query, string searchType = default, string region = default, string queryTime = "now 4-H", string geo = default);
    }
}