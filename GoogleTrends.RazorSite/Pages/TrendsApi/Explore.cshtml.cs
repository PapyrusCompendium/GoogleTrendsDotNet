using System.Threading.Tasks;

using GoogleTrends.Models.Explore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleTrends.RazorSite.Pages.TrendsApi {
    public class ExploreModel : PageModel {
        [BindProperty]
        public string SearchQuery { get; set; }

        public ExploreResponse ExploreResponse { get; set; }

        private readonly IGoogleTrendsClient _googleTrendsClient;

        public ExploreModel(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task<IActionResult> OnPostAsync() {
            ExploreResponse = await _googleTrendsClient.Explore.ExploreQuery(SearchQuery);
            return Page();
        }
    }
}
