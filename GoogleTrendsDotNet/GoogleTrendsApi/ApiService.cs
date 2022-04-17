using System.Collections.Specialized;
using System.Linq;
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

        protected static NameValueCollection AddParameters<TType>(TType apiParameter) where TType : ApiParameter {
            var parameters = HttpUtility.ParseQueryString(string.Empty);

            var apiProperties = apiParameter.GetType().GetProperties();
            foreach (var property in apiProperties.Where(i => i.GetCustomAttributes(true).Any(i => i is UrlParameterAttribute))) {
                var apiParameterAttribute = property.GetCustomAttributes(true).Single(i => i is UrlParameterAttribute) as UrlParameterAttribute;
                var propertyValue = property.GetValue(apiParameter)?.ToString();

                if (string.IsNullOrWhiteSpace(propertyValue)) {
                    continue;
                }

                parameters[apiParameterAttribute.UrlQueryName] = propertyValue;
            }

            return parameters;
        }

        protected async Task<TType> SendRequest<TType>(ApiParameter relatedQueryParameters, string apiUri, string jsonPath = default) {
            var parameters = AddParameters(relatedQueryParameters);

            var uriString = $"{apiUri}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<TType>(jsonPath);
        }
    }
}
