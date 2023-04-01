using System.Net;
using CyberTools.WebSearch;
using IPinfo;
using Whois;

var whois = new WhoisLookup();
var ipInfoToken = "MY_TOKEN"; // TODO: Move to appsettings.json
var ipInfoClient = new IPinfoClient.Builder()
    .AccessToken(ipInfoToken)
    .Build();

if (args == null || args.Length == 0 || args.Length % 2 != 0)
{
    Console.WriteLine("Invalid arguments"); // TODO: show documentation
    return;
}
var argDictionary = new Dictionary<string, string>();
for(var i = 0; i < args.Length; i += 2)
{
    argDictionary.Add(args[i], args[i + 1]);
}

if (argDictionary.ContainsKey("-searchQuery"))
{
    CreateFromSearch(argDictionary["-searchQuery"]);
}

if (argDictionary.ContainsKey("-fileName"))
{
    var domains = File.ReadAllLines(argDictionary["-fileName"]);
    CreateFromDomains(domains);
}

void CreateFromSearch(string searchQuery)
{
    var googleSearch = new GoogleSearchService();
    var lines = new List<string>();

    // Get 100 results, 10 at a time, which is the max google allows.
    for (var i = 1; i < 91; i += 10)
    {
        var googleResults = googleSearch.Search(searchQuery, i, "m6"); // Get next page of results no older than 6 months
        if (googleResults.Items == null) { break; }
        foreach (var item in googleResults.Items)
        {
            var lineParts = new List<string?>();
            var domainName = item.DisplayLink.Replace("www.", "");
            AddDomainInfo(lineParts, domainName);
            lineParts.Add("Google Custom Search");
            lineParts.Add(searchQuery);
            lineParts.Add(item.Title);
            lineParts.Add(item.Link);

            lines.Add($"\"{string.Join("\",\"", lineParts)}\"");
        }
    }
    File.WriteAllLines("SearchResults.csv", lines);
}

void CreateFromDomains(IList<string> domains)
{
    var lines = new List<string>();
    foreach (var domainName in domains)
    {
        var lineParts = new List<string?>();
        AddDomainInfo(lineParts, domainName);

        lines.Add($"\"{string.Join("\",\"", lineParts)}\"");
    }
}

void AddDomainInfo(IList<string> lineParts, string domainName)
{
    var ipAddress = Dns.GetHostAddresses(domainName).FirstOrDefault()?.ToString();
    var whoisInfo = whois.Lookup(domainName);
    var ipInfo = ipInfoClient.IPApi.GetDetails(ipAddress);

    lineParts.Add(domainName);
    lineParts.Add(whoisInfo?.Registrar?.Name);
    lineParts.Add(whoisInfo?.Registered == null ? "" : whoisInfo.Registered.Value.ToString("yyyy-MM-dd"));
    lineParts.Add(ipAddress);
    lineParts.Add(ipInfo.Country);
    lineParts.Add(whoisInfo?.Registrar?.IanaId);
    lineParts.Add(ipInfo.Asn.Name);
}