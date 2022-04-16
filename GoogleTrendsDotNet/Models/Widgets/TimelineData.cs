using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace GoogleTrends.Models.Widgets {
    public class TimelineData {
        [JsonProperty("time")]
        public string Time { get; set; }

        public DateTime ManagedTime {
            get {
                return !int.TryParse(Time, out var unixSeconds)
                    ? DateTime.UnixEpoch
                    : DateTime.UnixEpoch.AddSeconds(unixSeconds);
            }
        }

        [JsonProperty("formattedTime")]
        public string FormattedTime { get; set; }

        [JsonProperty("formattedAxisTime")]
        public string FormattedAxisTime { get; set; }

        [JsonProperty("value")]
        public List<int> Value { get; set; }

        [JsonProperty("hasData")]
        public List<bool> HasData { get; set; }

        [JsonProperty("formattedValue")]
        public List<string> FormattedValue { get; set; }
    }
}
