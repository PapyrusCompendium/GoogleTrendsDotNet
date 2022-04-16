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
        public int TimeZone {
            get {
                return (int)DateTimeOffset.Now.Offset.TotalMinutes;
            }
        }

        public string Region { get; set; }

        public string Token { get; set; }
    }
}
