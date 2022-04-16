using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;
using GoogleTrends.Models.GeoData;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IExploreApi {
        /// <summary>
        /// Requests Google Trend data from a search query.
        /// </summary>
        /// <param name="exploreQueryParameters"></param>
        /// <returns></returns>
        Task<ExploreResponse> ExploreQuery(ExploreQueryParameters exploreQueryParameters);

        /// <summary>
        /// Requests Google Trend data from a search query. Structs: <see cref="SearchType"/> <see cref="Regions"/> <see cref="QueryTimes"/> <see cref="GeoIds"/>
        /// </summary>
        /// <param name="query">The Search Query</param>
        /// <param name="searchType">The Search Type, Ex: Image search, Youtube search. <see cref="SearchType"/></param>
        /// <param name="region">The Region of the user doing the search. <see cref="Regions"/></param>
        /// <param name="queryTime">The period of time to query. <see cref="QueryTimes"/></param>
        /// <param name="geoSearch">The geographical location to search within. <see cref="GeoIds"/></param>
        /// <returns></returns>
        Task<ExploreResponse> ExploreQuery(string query, string searchType = default, string region = default, string queryTime = "now 4-H", string geoSearch = default);
    }
}