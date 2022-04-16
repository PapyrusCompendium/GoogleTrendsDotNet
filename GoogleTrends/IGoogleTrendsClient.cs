using GoogleTrends.GoogleTrendsApi;

namespace GoogleTrends {
    public interface IGoogleTrendsClient {
        RelatedQueryApi RelatedQuries { get; set; }
        GeoApi GeoLocation { get; set; }
        ExploreApi Explore { get; set; }
        AutoCompleteApi AutoComplete { get; set; }
    }
}