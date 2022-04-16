using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using GoogleTrends.Extensions;
using GoogleTrends.Models;

namespace GoogleTrends.GoogleTrendsApi {
    public class ApiService {

        protected GoogleTrendsClient _googleTrendsClient;

        public ApiService(GoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        protected static NameValueCollection AddDefaultParameters(ApiParameter apiParameter) {
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            parameters["hl"] = apiParameter.Region;
            parameters["tz"] = apiParameter.TimeZone.ToString();
            if (!string.IsNullOrWhiteSpace(apiParameter.Token)) {
                parameters["token"] = apiParameter.Token;
            }

            return parameters;
        }

        protected async Task<TType> SendRequest<TType>(ApiParameter relatedQueryParameters, string apiUri, string jsonRequest = default, string jsonPath = default) {
            var parameters = AddDefaultParameters(relatedQueryParameters);
            if (!string.IsNullOrWhiteSpace(jsonRequest)) {
                parameters["req"] = jsonRequest;
            }

            var uriString = $"{apiUri}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<TType>(jsonPath);
        }
    }
}
