using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.AutoComplete;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IAutoCompleteApi {
        Task<AutoCompleteSuggestion[]> GetAutoCompleteSuggestions(ApiParameter apiParameter, string query);
        Task<AutoCompleteSuggestion[]> GetAutoCompleteSuggestions(string searchQuery);
    }
}