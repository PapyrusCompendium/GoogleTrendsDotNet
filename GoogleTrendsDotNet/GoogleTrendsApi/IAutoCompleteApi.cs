using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.AutoComplete;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IAutoCompleteApi {
        /// <summary>
        /// Get recommended auto-completions from Google Trend.
        /// </summary>
        /// <param name="apiParameter"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<AutoCompleteSuggestion[]> GetAutoCompleteSuggestions(ApiParameter apiParameter, string query);

        /// <summary>
        /// Get recommended auto-completions from Google Trend.
        /// </summary>
        /// <param name="searchQuery">Partial search term.</param>
        /// <returns></returns>
        Task<AutoCompleteSuggestion[]> GetAutoCompleteSuggestions(string searchQuery);
    }
}