using GoogleTrends.GoogleTrendsApi;

namespace GoogleTrends {
    public interface IGoogleTrendsClient {
        /// <summary>
        /// Widgets: Related-Topics, Related-Queries, Geo-Populairty, Timeline-Popularity.
        /// </summary>
        IWidgetApi Widgets { get; set; }

        /// <summary>
        /// Geo Elements from server.
        /// </summary>
        IGeoApi GeoLocation { get; set; }

        /// <summary>
        /// Explore Google Trend Queries.
        /// </summary>
        IExploreApi Explore { get; set; }

        /// <summary>
        /// Google Trend recommended topics for auto-complete/partial queries.
        /// </summary>
        IAutoCompleteApi AutoComplete { get; set; }
    }
}