using System.Net;
using CyberTools.Files;
using CyberTools.WebSearch;

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

var csvService = new CsvService();

if (argDictionary.ContainsKey("-searchToCsv"))
{
    csvService.CreateFromSearch(argDictionary["-searchToCsv"]);
}

if (argDictionary.ContainsKey("-domainsToCsv"))
{
    var domains = File.ReadAllLines(argDictionary["-domainsToCsv"]);
    csvService.CreateFromDomains(domains);
}

if(argDictionary.ContainsKey("-googleAnnotations"))
{
    var googleSearch = new GoogleSearchService();
    var excludeDomains = File.ReadAllLines(argDictionary["-googleAnnotations"]);
    googleSearch.GetAnnotationsXml(excludeDomains, "");
}
