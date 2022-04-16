using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.GeoData;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IGeoApi {
        Task<GeoLocation> GetAllGeoLocations();
        Task<GeoLocation> GetAllGeoLocations(ApiParameter apiParameter);
    }
}