using System.Threading.Tasks;

using GoogleTrends.Models.GeoData;
using GoogleTrends.Models.Widgets;

namespace GoogleTrends.GoogleTrendsApi {
    public interface IWidgetApi {
        /// <summary>
        /// Get Geographical search data.
        /// </summary>
        /// <param name="widget"></param>
        /// <returns></returns>
        Task<GeoMapData[]> GetGeoDataWidget(Widget widget);

        /// <summary>
        /// Get Geographical search data.
        /// </summary>
        /// <param name="relatedQueryParameters"></param>
        /// <returns></returns>
        Task<GeoMapData[]> GetGeoDataWidget(WidgetRequestParameter relatedQueryParameters);

        /// <summary>
        /// Get Related search queries to explored query.
        /// </summary>
        /// <param name="widget"></param>
        /// <returns></returns>
        Task<RankedList[]> GetRelatedQueriesWidget(Widget widget);

        /// <summary>
        /// Get Related search queries to explored query.
        /// </summary>
        /// <param name="relatedQueryParameters"></param>
        /// <returns></returns>
        Task<RankedList[]> GetRelatedQueriesWidget(WidgetRequestParameter relatedQueryParameters);

        /// <summary>
        /// Get Timeline popularity for explored query.
        /// </summary>
        /// <param name="widget"></param>
        /// <returns></returns>
        Task<TimelineData[]> GetTimelineWidget(Widget widget);

        /// <summary>
        /// Get Timeline popularity for explored query.
        /// </summary>
        /// <param name="relatedQueryParameters"></param>
        /// <returns></returns>
        Task<TimelineData[]> GetTimelineWidget(WidgetRequestParameter relatedQueryParameters);
    }
}