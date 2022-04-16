<p align="center">
	<img src="https://raw.githubusercontent.com/PapyrusCompendium/GoogleTrendsDotNet/master/GoogleTrendsDotNet/images/GoogleTrendsDotNet.png"/>
	<h3 align="center">GoogleTrends Api In .NET Core</h3>
</p>

[![Pipeline](https://github.com/PapyrusCompendium/GoogleTrendsDotNet/actions/workflows/main.yml/badge.svg?branch=master&event=status)](https://github.com/PapyrusCompendium/GoogleTrendsDotNet/actions/workflows/main.yml)
![Nuget](https://img.shields.io/nuget/v/GoogleTrendsDotNet)
![Nuget](https://img.shields.io/nuget/dt/GoogleTrendsDotNet)

# GoogleTrendsDotNet

Unofficial Google Trends C# Api.

This is a fully implemented Wrapper of the google trends api located here: <a href="https://trends.google.com/trends/">Google Trends</a>  
This api makes google trends incredibly easy to consume from C#.

## Console Application

```cs
    private static async Task QueryData() {
        var trendsClient = new GoogleTrendsClient();

        var exploreData = await trendsClient.Explore.ExploreQuery("DotNet", SearchType.WebSearch,
            Regions.UnitedStates, QueryTimes.PastMonth, RegionIds.UnitedStates);

        var relatedSearches = await exploreData.GetRelatedQueries();
        Console.WriteLine("Top 5 Related Searches:");
        foreach (var query in relatedSearches.SelectMany(i => i.RankedKeywords).OrderByDescending(i => i.Value).Take(5)) {
            Console.WriteLine($"({query.FormattedValue}) {query.Query}");
        }
        Console.WriteLine();
    }
```

## HostBuilder

Startup.cs:

```cs
    public void ConfigureServices(IServiceCollection services) {
        services.AddSingleton<IGoogleTrendsClient, GoogleTrendsClient>()
            .AddSingleton<IDotNetService, DotNetService>();
    }
```

Service:

```cs
    public class DotNetService : IDotNetService {
        private readonly IGoogleTrendsClient _googleTrendsClient;
        public DotNetService(IGoogleTrendsClient googleTrendsClient){
            _googleTrendsClient = googleTrendsClient;
        }

        public void PrintTrendDetails(){
            var exploreData = await _googleTrendsClient.Explore.ExploreQuery("DotNet", SearchType.WebSearch,
            Regions.UnitedStates, QueryTimes.PastMonth, RegionIds.UnitedStates);

            var relatedSearches = await exploreData.GetRelatedQueries();
            Console.WriteLine("Top 5 Related Searches:");
            foreach (var query in relatedSearches.SelectMany(i => i.RankedKeywords).OrderByDescending(i => i.Value).Take(5)) {
                Console.WriteLine($"({query.FormattedValue}) {query.Query}");
            }
            Console.WriteLine();

            var relatedTopics = await exploreData.GetRelatedTopics();
            Console.WriteLine("Top 5 Related Topics");
            foreach (var topic in relatedTopics.SelectMany(i => i.RankedKeywords).OrderByDescending(i => i.Value).Take(5)) {
                Console.WriteLine($"({topic.FormattedValue}) {topic.Topic.Title}");
            }
            Console.WriteLine();

            var geoMapData = await exploreData.GetGeoMapData();
            Console.WriteLine("Top 5 Locations Searched From:");
            foreach (var location in geoMapData.OrderByDescending(i => i.Value.FirstOrDefault()).Take(5)) {
                Console.WriteLine($"({location.Value.FirstOrDefault()}) {location.GeoName}");
            }
            Console.WriteLine();

            var timeLineData = await exploreData.GetTimeLineData();
            Console.WriteLine("Top 5 Peak Search Times:");
            foreach (var searchTime in timeLineData.OrderByDescending(i => i.Value.FirstOrDefault()).Take(5)) {
                if (!int.TryParse(searchTime.Time, out var unixSeconds)) {
                    continue;
                }

                var dateTime = DateTime.UnixEpoch.AddSeconds(unixSeconds);
                Console.WriteLine($"({searchTime.Value.FirstOrDefault()}) {dateTime:yyyy-MMM-dd-HH-mm}");
            }
        }

    }
```
