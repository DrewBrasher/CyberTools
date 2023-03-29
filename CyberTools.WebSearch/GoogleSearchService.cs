using System;
using RestSharp;

namespace CyberTools.WebSearch;

public partial class GoogleSearchService
{
    private const string ApiKey = "PutYourKeyHere"; // TODO: Move to appsettings.json
    private const string SearchBaseUrl = "https://www.googleapis.com/customsearch/v1";
    private const string SearchEngineId = "PutYourSearchEngineIdHere"; // TODO: Move to appsettings.json

    public GoogleSearchService()
    {
    }

    /// <summary>
    /// Search using the Custom Search API
    /// https://developers.google.com/custom-search/v1/reference/rest/v1/cse/list
    /// </summary>
    /// <param name="searchQuery"></param>
    /// <param name="start"></param>
    /// <param name="dateRestrict"></param>
    /// <param name="exactTerms"></param>
    /// <param name="excludeTerms"></param>
    /// <returns></returns>
    public GoogleSearchResponse Search(string searchQuery,
        int start = 1,
        string? dateRestrict = null,
        string? exactTerms = null,
        string? excludeTerms = null)
    {
        var client = new RestClient(SearchBaseUrl);

        var resourceUrl = $"?key={ApiKey}&cx={SearchEngineId}&q={searchQuery}";
        resourceUrl += start > 1 ? $"&start={start}" : "";
        resourceUrl += dateRestrict != null ? $"&dateRestrict={dateRestrict}" : "";
        resourceUrl += exactTerms != null ? $"&exactTerms={exactTerms}" : "";
        resourceUrl += excludeTerms != null ? $"&excludeTerms={excludeTerms}" : "";

        var searchResponse = client.GetJson<GoogleSearchResponse>(resourceUrl);
         return searchResponse;
    }
}