using System.Threading.Tasks;

using GoogleTrends.Models.RealtimeTrends;
using GoogleTrends.Models.RealtimeTrends.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IRealtimeTrendsApi {
        Task<DailyTrends> GetDailyTrends();
        Task<DailyTrends> GetDailyTrends(DailyTrendsParameters dailyTrendsParameters);
        Task<RealTimeTrends> GetRealtimeTrends();
        Task<RealTimeTrends> GetRealtimeTrends(RealTimeTrendsParameters realTimeTrendsParameters);
    }
}