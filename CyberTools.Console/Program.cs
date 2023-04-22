using System.Net;
using CyberTools.Files;
using CyberTools.WebSearch;

if (args == null || args.Length == 0 || args.Length % 2 != 0)
{
    Console.WriteLine("Valid arguments:" + Environment.NewLine);
    Console.WriteLine("-searchToCsv:       Searches for the given search term using Google Programable Search Engine");
    Console.WriteLine("                    and creates a csv file with whois info.");
    Console.WriteLine("                    Must be surrounded by double quotes if search term contains spaces.");
    Console.WriteLine("                    If a double quote is part of your search term, it must be escapes with a backslash (\\\")." + Environment.NewLine);
    Console.WriteLine("-searchFileToCsv:   Takes a filename that contains a list of search terms and does the same as running -searchToCsv or each term" + Environment.NewLine);
    Console.WriteLine("-domainsToCsv:      Takes a text file list of domain names and creates a csv file with whois info." + Environment.NewLine);
    Console.WriteLine("-googleAnnotations: Takes a text file list of domain names and creates an exlude list annotations xml file" + Environment.NewLine);
    Console.WriteLine("                    That can be uploaded to your Google Programmable Search Engine" + Environment.NewLine);
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

if(argDictionary.ContainsKey("-searchFileToCsv"))
{
    var searchTerms = File.ReadAllLines(argDictionary["-searchFileToCsv"]);
    csvService.CreateFromSearch(searchTerms);
}

if (argDictionary.ContainsKey("-domainsToCsv"))
{
    var domains = File.ReadAllLines(argDictionary["-domainsToCsv"]);
    csvService.CreateFromDomains(domains);
}

if(argDictionary.ContainsKey("-googleAnnotations"))
{
    var fileName = argDictionary["-googleAnnotations"];
    var googleSearch = new GoogleSearchService();
    var excludeDomains = File.ReadAllLines(fileName);
    var xmlString = googleSearch.GetAnnotationsXml(excludeDomains, fileName.Substring(fileName.LastIndexOf("\\") + 1));
    File.WriteAllText(fileName.Substring(0, fileName.LastIndexOf(".")) + ".xml", xmlString);
}
