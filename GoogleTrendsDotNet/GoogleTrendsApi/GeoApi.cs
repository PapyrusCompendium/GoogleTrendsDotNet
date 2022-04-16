using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.GeoData;

namespace GoogleTrends.GoogleTrendsApi {
    public class GeoApi : ApiService, IGeoApi {
        private const string GEO_SETTINGS = "api/explore/pickers/geo";

        public GeoApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<GeoLocation> GetAllGeoLocations() {
            return await GetAllGeoLocations(new ApiParameter {
                Region = Regions.UnitedStates
            });
        }

        public async Task<GeoLocation> GetAllGeoLocations(ApiParameter apiParameter) {
            return await SendRequest<GeoLocation>(apiParameter, GEO_SETTINGS);
        }
    }
}
