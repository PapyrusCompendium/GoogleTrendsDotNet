using System.Linq;
using System.Threading.Tasks;

using GoogleTrends.Models.Explore;
using GoogleTrends.Models.Widgets;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleTrends.RazorSite.Pages.TrendsApi {
    public class ExploreModel : PageModel {
        private const string RELATED_QUERIES_ID = "RELATED_QUERIES";
        private const string RELATED_TOPICS_ID = "RELATED_TOPICS";

        [BindProperty]
        public string SearchQuery { get; set; }

        public ExploreResponse ExploreResponse { get; set; }
        public RelatedWidgetResponse RelatedQueriesResponse { get; set; }
        public RelatedWidgetResponse RelatedTopicsResponse { get; set; }


        private readonly IGoogleTrendsClient _googleTrendsClient;

        public ExploreModel(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task<IActionResult> OnPostAsync() {
            ExploreResponse = await _googleTrendsClient.Explore.ExploreQuery(SearchQuery);

            var relatedQueriesWidget = ExploreResponse.Widgets.FirstOrDefault(i => i.Id == RELATED_QUERIES_ID);
            RelatedQueriesResponse = await _googleTrendsClient.RelatedQuries.FindRelatedQueries(relatedQueriesWidget.Request, relatedQueriesWidget.Token);

            var relatedTopicsWidget = ExploreResponse.Widgets.FirstOrDefault(i => i.Id == RELATED_TOPICS_ID);
            RelatedTopicsResponse = await _googleTrendsClient.RelatedQuries.FindRelatedQueries(relatedTopicsWidget.Request, relatedTopicsWidget.Token);
            return Page();
        }
    }
}
