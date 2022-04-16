using System.Collections.Specialized;
using System.Web;

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
    }
}
