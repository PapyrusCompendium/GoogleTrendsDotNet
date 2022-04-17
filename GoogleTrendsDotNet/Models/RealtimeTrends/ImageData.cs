
using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class ImageData {
        [JsonProperty("newsUrl")]
        public string NewsUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("imgUrl")]
        internal string ImgUrl { get; set; }

        [JsonProperty("imageUrl")]
        internal string ImageUrl { get; set; }

        public string ImageSourceUrl {
            get {
                return !string.IsNullOrWhiteSpace(ImgUrl) ? ImgUrl : ImageUrl;
            }
        }
    }
}
