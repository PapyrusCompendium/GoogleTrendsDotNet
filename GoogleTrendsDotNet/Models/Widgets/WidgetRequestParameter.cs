namespace GoogleTrends.Models.Widgets {
    public class WidgetRequestParameter : ApiParameter {
        [UrlParameter("req")]
        public WidgetRequest Query { get; set; }
    }
}
