using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.RealtimeTrends {
    public class TrendingSearchesDay {
        [JsonProperty("date")]
        public string Date { get; set; }

        public DateTime ManagedDate {
            get {
                return !int.TryParse(Date, out var epochSeconds)
                    ? DateTime.UnixEpoch
                    : DateTime.UnixEpoch.AddSeconds(epochSeconds);
            }
        }

        [JsonProperty("formattedDate")]
        public string FormattedDate { get; set; }

        [JsonProperty("trendingSearches")]
        public List<TrendingSearch> TrendingSearches { get; set; }
    }
}
