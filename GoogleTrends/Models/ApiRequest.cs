using Newtonsoft.Json;

namespace GoogleTrends.Models {
    public class ApiRequest {
        [JsonProperty("requestOptions")]
        public RequestOptions RequestOptions { get; set; }
    }
}
