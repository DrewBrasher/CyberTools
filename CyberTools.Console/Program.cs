using System.Net;
using CyberTools.WebSearch;
using Whois;

Console.WriteLine("Enter search query: ");
var searchQuery = Console.ReadLine();
var googleSearch = new GoogleSearchService();
var whois = new WhoisLookup();
var lines = new List<string>();

// Get 100 results, 10 at a time, which is the max google allows.
for (var i = 1; i < 11; i += 10)
{
    var googleResults = googleSearch.Search(searchQuery, i, "m6"); // Get next page of results no older than 6 months
    if (googleResults.Items == null) { break; }
    foreach (var item in googleResults.Items)
    {
        var lineParts = new List<string?>();
        var domainName = item.DisplayLink.Replace("www.", "");
        var iPAddresses = Dns.GetHostAddresses(domainName);
        var whoisInfo = whois.Lookup(domainName);

        lineParts.Add(domainName);
        lineParts.Add(whoisInfo?.Registrar?.Name);
        lineParts.Add(whoisInfo?.Registered == null ? "" : whoisInfo.Registered.Value.ToString("yyyy-MM-dd"));
        lineParts.Add(iPAddresses.FirstOrDefault()?.ToString());
        lineParts.Add(""); //TODO: get country
        lineParts.Add(whoisInfo?.Registrar?.IanaId);
        lineParts.Add(""); // TODO: get AS Organization


        lines.Add($"\"{string.Join("\",\"", lineParts)}\"");
    }
}
File.WriteAllLines("SearchResults.csv", lines);
//Console.ReadKey();
 