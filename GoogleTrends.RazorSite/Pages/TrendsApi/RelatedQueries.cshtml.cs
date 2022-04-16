using System.Threading.Tasks;

using GoogleTrends.Models;
using GoogleTrends.Models.RelatedQueries;
using GoogleTrends.Models.RelatedQueries.Request;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleTrends.RazorSite.Pages.TrendsApi {
    public class RelatedQueriesModel : PageModel {
        [BindProperty]
        public string SearchQuery { get; set; }
        public RelatedQueriesResponse RelatedQueriesResponse { get; set; }

        private readonly IGoogleTrendsClient _googleTrendsClient;

        public RelatedQueriesModel(IGoogleTrendsClient googleTrendsClient) {
            _googleTrendsClient = googleTrendsClient;
        }

        public async Task<IActionResult> OnPostAsync() {
            RelatedQueriesResponse = await _googleTrendsClient.RelatedQuries
                .FindRelatedQueries(ConstructRelatedSearchesQuery());

            return Page();
        }

        private RelatedQueryParameters ConstructRelatedSearchesQuery() {
            return new RelatedQueryParameters {
                Region = Regions.UnitedStates,
                Query = new() {
                    KeywordType = "QUERY",
                    Language = "en",
                    UserCountryCode = "US",
                    Metric = new() {
                        "TOP",
                        "RISING"
                    },
                    TrendinessSettings = new() {
                        CompareTime = "2020-04-15 2021-04-15"
                    },
                    RequestOptions = new() {
                        Property = string.Empty,
                        Backend = "IZG",
                        Category = 0
                    },
                    Restriction = new() {
                        Geo = new() {
                            Country = "US"
                        },
                        Time = "2021-04-16 2022-04-16",
                        OriginalTimeRangeForExploreUrl = "today 12-m",
                        ComplexKeywordsRestriction = new() {
                            Keyword = new() {
                                new() {
                                    Type = "BROAD",
                                    Value = SearchQuery
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
