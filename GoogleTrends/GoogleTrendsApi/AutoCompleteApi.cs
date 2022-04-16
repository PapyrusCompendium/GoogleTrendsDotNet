using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.AutoComplete;

namespace GoogleTrends.GoogleTrendsApi {
    public class AutoCompleteApi : ApiService {
        private const string AUTO_COMPLETE = "api/autocomplete";

        public AutoCompleteApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<AutoCompleteResponse> GetAutoCompleteSuggestions(string searchQuery) {
            return await GetAutoCompleteSuggestions(new ApiParameter() {
                Region = Regions.UnitedStates
            }, searchQuery);
        }

        public async Task<AutoCompleteResponse> GetAutoCompleteSuggestions(ApiParameter apiParameter, string query) {
            var parameters = AddDefaultParameters(apiParameter);

            var uriString = $"{AUTO_COMPLETE}/{query}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);

            return response.As<AutoCompleteResponse>("default");
        }
    }
}
