using System;
using System.Net.Http;
using System.Reflection;

using GoogleTrends.GoogleTrendsApi;

namespace GoogleTrends {
    public class GoogleTrendsClient : IGoogleTrendsClient {
        internal const string SOURCE_CONTROL_LINK = "https://github.com/PapyrusCompendium/GoogleTrendsDotNet";
        internal HttpClient _httpClient;

        public GoogleTrendsClient() {
            _httpClient = new() {
                BaseAddress = new Uri("https://trends.google.com/trends/")
            };

            var cookieRequest = new HttpRequestMessage(HttpMethod.Get, string.Empty);
            _httpClient.Send(cookieRequest);

            _httpClient.DefaultRequestHeaders.UserAgent.Clear();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd($"Dotnet Trends Api Client/{Assembly.GetExecutingAssembly().ImageRuntimeVersion} ({SOURCE_CONTROL_LINK})");

            Widgets = new(this);
            GeoLocation = new(this);
            Explore = new(this);
            AutoComplete = new(this);
        }

        public ExploreApi Explore { get; set; }

        public AutoCompleteApi AutoComplete { get; set; }

        public WidgetApi Widgets { get; set; }

        public GeoApi GeoLocation { get; set; }
    }
}
