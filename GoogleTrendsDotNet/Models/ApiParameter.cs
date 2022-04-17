using System;

namespace GoogleTrends.Models {
    public struct Regions {
        public static string Arabic => "ar";
        public static string UnitedStates => "en-US";
        public static string UnitedKingdom => "en-GB";
        public static string Hebrew => "iw";
        public static string Chinese => "zh-CN";
        public static string Taiwan => "zh-TW";
    }

    public class ApiParameter {
        [UrlParameter("tz")]
        public int TimeZone {
            get {
                return (int)Math.Abs(DateTimeOffset.Now.Offset.TotalMinutes);
            }
        }

        /// <summary>
        /// <see cref="Regions"/>
        /// </summary>
        [UrlParameter("hl")]
        public string Region { get; set; }

        [UrlParameter("token")]
        public string Token { get; set; }
    }
}
