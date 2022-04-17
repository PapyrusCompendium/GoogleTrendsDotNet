using System.Threading.Tasks;

using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Explore.Request;
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IExploreApi {
        /// <summary>
        /// Requests Google Trend data from a search query.
        /// </summary>
        /// <param name="exploreQueryParameters"></param>
        /// <returns></returns>
        Task<ExploreResponse> ExploreQuery(ExploreQueryParameters exploreQueryParameters);

        /// <summary>
        /// Requests Google Trend data from a search query.
        /// </summary>
        /// <param name="query">The Search Query</param>
        /// <param name="searchType">The Search Type, Ex: Image search, Youtube search. <see cref="SearchType"/></param>
        /// <param name="region">The Region of the user doing the search. <see cref="UserRegion"/></param>
        /// <param name="queryTime">The period of time to query. <see cref="QueryTimes"/></param>
        /// <param name="geoSearch">The geographical location to search within. <see cref="GeoId"/></param>
        /// <returns></returns>
        Task<ExploreResponse> ExploreQuery(string query, SearchType searchType = default,
            UserRegion userRegion = default, QueryTimes queryTime = default, GeoId geoSearch = default);
    }
}