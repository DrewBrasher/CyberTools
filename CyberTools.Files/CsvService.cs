using CyberTools.WebSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IPinfo;
using Whois;

namespace CyberTools.Files;
public class CsvService
{
    private readonly WhoisLookup _whois;
    private readonly IPinfoClient _ipInfoClient;

    public CsvService()
    {
        _whois = new WhoisLookup();
        var ipInfoToken = "MY_TOKEN"; // TODO: Move to appsettings.json
        _ipInfoClient = new IPinfoClient.Builder()
            .AccessToken(ipInfoToken)
            .Build();
    }

    public void CreateFromSearch(string searchQuery, string? dateRestrict = null)
    {
        var googleSearch = new GoogleSearchService();
        var lines = new List<string>
        {
            "Domain,Registrar,Date Registered,IP Address,Country,AS Number,AS Organization,Search Engine Used,Search Term/Image Used,Search Result Title,Search Result Link"
        };

        // Get 100 results, 10 at a time, which is the max google allows.
        for(var i = 1; i < 91; i += 10)
        {
            var googleResults = googleSearch.Search(searchQuery, i, dateRestrict); // use "m6" to get next page of results no older than 6 months
            if(googleResults.Items == null) { break; }
            foreach(var item in googleResults.Items)
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

    public void CreateFromDomains(IList<string> domains)
    {
        var lines = new List<string>
        {
            "Domain,Registrar,Date Registered,IP Address,Country,AS Number,AS Organization"
        };
        foreach(var domainName in domains)
        {
            var lineParts = new List<string?>();
            AddDomainInfo(lineParts, domainName);

            lines.Add($"\"{string.Join("\",\"", lineParts)}\"");
        }
        File.WriteAllLines("DomainInfo.csv", lines);
    }

    protected void AddDomainInfo(IList<string> lineParts, string domainName)
    {
        lineParts.Add(domainName);
        try
        {
            var ipAddresses = Dns.GetHostAddresses(domainName);
            var ipAddress = ipAddresses.LastOrDefault()?.ToString();
            var whoisInfo = _whois.Lookup(domainName);
            var ipInfo = _ipInfoClient.IPApi.GetDetails(ipAddress);

            var asInfo = ipInfo.Org.Split(" ", 2);

            lineParts.Add(whoisInfo?.Registrar?.Name);
            lineParts.Add(whoisInfo?.Registered == null ? "" : whoisInfo.Registered.Value.ToString("yyyy-MM-dd"));
            lineParts.Add(ipAddress);
            lineParts.Add(ipInfo.Country);
            lineParts.Add(asInfo[0].Replace("AS", ""));
            lineParts.Add(asInfo[1]);
        }
        catch(Exception ex)
        {
            lineParts.Add("Error getting domain info,,,,,");
        }
    }
}
