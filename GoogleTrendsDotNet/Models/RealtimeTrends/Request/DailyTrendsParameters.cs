using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.Models.RealtimeTrends.Request {
    public class DailyTrendsParameters : ApiParameter {
        [UrlParameter("geo")]
        public GeoId GeographicalLocation { get; set; }

        [UrlParameter("ns")]
        public int NS { get; set; }
    }
}
