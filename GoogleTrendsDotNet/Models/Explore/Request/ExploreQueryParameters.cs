namespace GoogleTrends.Models.Explore.Request {
    public class ExploreQueryParameters : ApiParameter {
        [UrlParameter("req")]
        public ExploreRequest Request { get; set; }
    }
}
