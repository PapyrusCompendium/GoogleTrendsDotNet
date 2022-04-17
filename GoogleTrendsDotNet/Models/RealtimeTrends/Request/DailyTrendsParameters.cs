namespace GoogleTrends.Models.RealtimeTrends.Request {
    public class DailyTrendsParameters : ApiParameter {
        /// <summary>
        /// <see cref="GeoIds"/>
        /// </summary>
        [UrlParameter("geo")]
        public string GeographicalLocation { get; set; }

        [UrlParameter("ns")]
        public int NS { get; set; }
    }
}
