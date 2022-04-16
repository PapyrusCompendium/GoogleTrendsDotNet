using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.AutoComplete {
    public class AutoCompleteResponse {
        [JsonProperty("topics")]
        public List<AutoCompleteSuggestion> AutoCompleteSuggestions { get; set; }
    }
}
