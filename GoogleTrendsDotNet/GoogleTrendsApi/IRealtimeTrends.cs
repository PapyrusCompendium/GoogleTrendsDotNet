using System.Threading.Tasks;

using GoogleTrends.Models.RealtimeTrends;
using GoogleTrends.Models.RealtimeTrends.Request;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IRealtimeTrends {
        Task<DailyTrends> GetDailyTrends();
        Task<DailyTrends> GetDailyTrends(DailyTrendsParameters dailyTrendsParameters);
    }
}