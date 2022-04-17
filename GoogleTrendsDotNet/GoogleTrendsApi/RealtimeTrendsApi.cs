using System.Threading.Tasks;

using GoogleTrends.Models.ParameterTypes;
using GoogleTrends.Models.RealtimeTrends;
using GoogleTrends.Models.RealtimeTrends.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public class RealtimeTrendsApi : ApiService, IRealtimeTrendsApi {
        private const string DAILY_TRENDS = "api/dailytrends";
        private const string REAL_TIME_TRENDS = "api/realtimetrends";

        public RealtimeTrendsApi(GoogleTrendsClient googleTrendsClient) : base(googleTrendsClient) {
        }

        public async Task<RealTimeTrends> GetRealtimeTrends() {
            return await GetRealtimeTrends(new RealTimeTrendsParameters {
                Category = TrendCategory.All,
                Region = UserRegion.UnitedStates,
                GeographicalLocation = GeoId.UnitedStates
            });
        }

        public async Task<RealTimeTrends> GetRealtimeTrends(RealTimeTrendsParameters realTimeTrendsParameters) {
            return await SendRequest<RealTimeTrends>(realTimeTrendsParameters, REAL_TIME_TRENDS);
        }

        public async Task<DailyTrends> GetDailyTrends() {
            return await GetDailyTrends(new DailyTrendsParameters {
                Region = UserRegion.UnitedStates,
                GeographicalLocation = GeoId.UnitedStates
            });
        }

        public async Task<DailyTrends> GetDailyTrends(DailyTrendsParameters dailyTrendsParameters) {
            return await SendRequest<DailyTrends>(dailyTrendsParameters, DAILY_TRENDS, "$.default");
        }
    }
}
