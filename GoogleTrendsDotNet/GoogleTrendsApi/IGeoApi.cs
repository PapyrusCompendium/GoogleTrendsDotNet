using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.GeoData;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IGeoApi {
        /// <summary>
        /// Get every child Geo element of WorldWide element.
        /// </summary>
        /// <returns></returns>
        Task<GeoLocation> GetAllGeoLocations();

        /// <summary>
        /// Get every child Geo element of WorldWide element.
        /// </summary>
        /// <param name="apiParameter"></param>
        /// <returns></returns>
        Task<GeoLocation> GetAllGeoLocations(ApiParameter apiParameter);
    }
}