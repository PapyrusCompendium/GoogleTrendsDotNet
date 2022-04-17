using System.Threading.Tasks;

using GoogleTrends.Models.RealtimeTrends;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleTrends.RazorSite.Pages.TrendsApi {
    public class DailyTrendsModel : PageModel {
        public DailyTrends DailyTrends { get; set; }
        public RealTimeTrends RealTimeTrends { get; set; }

        private readonly IGoogleTrendsClient _googleTrendsClient;

        public DailyTrendsModel(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task OnGetAsync() {
            DailyTrends = await _googleTrendsClient.RealtimeTrends.GetDailyTrends();
            RealTimeTrends = await _googleTrendsClient.RealtimeTrends.GetRealtimeTrends();
        }
    }
}
