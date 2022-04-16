
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace GoogleTrends.RazorSite.Controllers {
    [Route("api/[controller]")]
    public class AutoCompleteQuery : Controller {
        private readonly IGoogleTrendsClient _googleTrendsClient;

        public AutoCompleteQuery(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        [ValidateAntiForgeryToken]
        [HttpGet]
        public async Task<IActionResult> GetRecommendedQueries(string searchQuery) {
            var autoCompleteResults = await _googleTrendsClient.AutoComplete.GetAutoCompleteSuggestions(searchQuery);
            return Ok(autoCompleteResults.AutoCompleteSuggestions.Select(i => i.Title));
        }
    }
}
