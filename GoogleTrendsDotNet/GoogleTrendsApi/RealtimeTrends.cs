using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.RealtimeTrends;
using GoogleTrends.Models.RealtimeTrends.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public class RealtimeTrends : ApiService, IRealtimeTrends {
        private const string DAILY_TRENDS = "api/dailytrends";

        public RealtimeTrends(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        //public async Task<RealtimeTrends> GetRealtimeTrends() {
        //    return await SendRequest<RealtimeTrends>(apiParameter, GEO_SETTINGS);
        //}

        public async Task<DailyTrends> GetDailyTrends() {
            return await GetDailyTrends(new DailyTrendsParameters {
                Region = Regions.UnitedStates,
                GeographicalLocation = GeoIds.UnitedStates
            });
        }

        public async Task<DailyTrends> GetDailyTrends(DailyTrendsParameters dailyTrendsParameters) {
            return await SendRequest<DailyTrends>(dailyTrendsParameters, DAILY_TRENDS, "$.default");
        }
    }
}
