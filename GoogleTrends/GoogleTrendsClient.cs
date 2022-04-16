using System;
using System.Net.Http;
using System.Reflection;

namespace GoogleTrends {
    public class GoogleTrendsClient {
        internal HttpClient _httpClient;

        public GoogleTrendsClient() {
            _httpClient = new() {
                BaseAddress = new Uri("https://trends.google.com/trends/api")
            };

            _httpClient.DefaultRequestHeaders.UserAgent.Clear();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd($"Dotnet Trends Api Client/{Assembly.GetExecutingAssembly().ImageRuntimeVersion}");
        }


    }
}
