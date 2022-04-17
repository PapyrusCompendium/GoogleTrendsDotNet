using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.Models.RealtimeTrends.Request {
    public class RealTimeTrendsParameters : ApiParameter {
        [UrlParameter("cat")]
        public TrendCategory Category { get; set; }

        /// <summary>
        /// Unsure
        /// </summary>
        [UrlParameter("fi")]
        public int FI { get; set; } = 0;

        /// <summary>
        /// Unsure
        /// </summary>
        [UrlParameter("fs")]
        public int FS { get; set; } = 0;

        [UrlParameter("geo")]
        public GeoId GeographicalLocation { get; set; }

        /// <summary>
        /// Unsure
        /// </summary>
        [UrlParameter("ri")]
        public int RI { get; set; } = 300;

        /// <summary>
        /// Unsure
        /// </summary>
        [UrlParameter("rs")]
        public int RS { get; set; } = 20;

        [UrlParameter("sort")]
        public int Sort { get; set; } = 0;
    }
}
