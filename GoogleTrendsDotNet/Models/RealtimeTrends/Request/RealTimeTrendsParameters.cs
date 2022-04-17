namespace GoogleTrends.Models.RealtimeTrends.Request {
    public class RealTimeTrendsParameters : ApiParameter {
        [UrlParameter("cat")]
        public string Category { get; set; }

        [UrlParameter("fi")]
        public int FI { get; set; }

        [UrlParameter("fs")]
        public int FS { get; set; }

        /// <summary>
        /// <see cref="GeoIds"/>
        /// </summary>
        [UrlParameter("geo")]
        public string GeographicalLocation { get; set; }

        [UrlParameter("ri")]
        public int RI { get; set; }

        [UrlParameter("rs")]
        public int RS { get; set; }

        [UrlParameter("sort")]
        public int Sort { get; set; }
    }
}
