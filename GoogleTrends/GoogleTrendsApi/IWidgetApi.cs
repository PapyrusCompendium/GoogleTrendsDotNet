using System.Threading.Tasks;

using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Widgets;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IWidgetApi {
        Task<GeoMapData[]> GetGeoDataWidget(Widget widget);
        Task<GeoMapData[]> GetGeoDataWidget(WidgetRequestParameter relatedQueryParameters);
        Task<RankedList[]> GetRelatedQueriesWidget(Widget widget);
        Task<RankedList[]> GetRelatedQueriesWidget(WidgetRequestParameter relatedQueryParameters);
        Task<TimelineData[]> GetTimelineWidget(Widget widget);
        Task<TimelineData[]> GetTimelineWidget(WidgetRequestParameter relatedQueryParameters);
    }
}