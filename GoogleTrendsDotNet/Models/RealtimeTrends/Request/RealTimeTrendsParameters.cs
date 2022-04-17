using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.Models.RealtimeTrends.Request {
    public class RealTimeTrendsParameters : ApiParameter {
        [UrlParameter("cat")]
        public TrendCategory Category { get; set; }

        [UrlParameter("fi")]
        public int FI { get; set; }

        [UrlParameter("fs")]
        public int FS { get; set; }

        [UrlParameter("geo")]
        public GeoId GeographicalLocation { get; set; }

        [UrlParameter("ri")]
        public int RI { get; set; }

        [UrlParameter("rs")]
        public int RS { get; set; }

        [UrlParameter("sort")]
        public int Sort { get; set; }
    }
}
