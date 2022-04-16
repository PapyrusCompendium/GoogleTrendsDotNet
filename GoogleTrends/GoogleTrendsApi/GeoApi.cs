using System;
using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.GeoData;

namespace GoogleTrends.GoogleTrendsApi {
    public class GeoApi : ApiService {
        private const string GEO_SETTINGS = "api/explore/pickers/geo";

        public GeoApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<GeoLocation> GetAllGeoLocations(ApiParameter apiParameter) {
            var parameters = AddDefaultParameters(apiParameter);

            var requestUri = new UriBuilder(GEO_SETTINGS) {
                Query = parameters.ToString()
            };

            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, requestUri.Uri);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<GeoLocation>();
        }
    }
}
