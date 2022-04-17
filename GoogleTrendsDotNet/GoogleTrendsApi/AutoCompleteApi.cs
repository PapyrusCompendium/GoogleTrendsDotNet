using System.Net.Http;
using System.Threading.Tasks;

using GoogleTrends.Extensions;
using GoogleTrends.Models;
using GoogleTrends.Models.AutoComplete;

namespace GoogleTrends.GoogleTrendsApi {
    public class AutoCompleteApi : ApiService, IAutoCompleteApi {
        private const string AUTO_COMPLETE = "api/autocomplete";

        public AutoCompleteApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<AutoCompleteSuggestion[]> GetAutoCompleteSuggestions(string searchQuery) {
            return await GetAutoCompleteSuggestions(new ApiParameter() {
                Region = Regions.UnitedStates
            }, searchQuery);
        }

        public async Task<AutoCompleteSuggestion[]> GetAutoCompleteSuggestions(ApiParameter apiParameter, string query) {
            var parameters = AddParameters(apiParameter);
            var uriString = $"{AUTO_COMPLETE}/{query}?{parameters}";
            var relatedQueryRequest = new HttpRequestMessage(HttpMethod.Get, uriString);

            var response = await _googleTrendsClient._httpClient.SendAsync(relatedQueryRequest);
            return response.As<AutoCompleteSuggestion[]>("$.default.topics");
        }
    }
}
