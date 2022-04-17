using System;

using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.Models {
    public class ApiParameter {
        [UrlParameter("tz")]
        public int TimeZone {
            get {
                return (int)Math.Abs(DateTimeOffset.Now.Offset.TotalMinutes);
            }
        }

        [UrlParameter("hl")]
        public UserRegion Region { get; set; }

        [UrlParameter("token")]
        public string Token { get; set; }
    }
}