using CyberTools.WebSearch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CyberTools.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public List<Item> SearchResults { get; set; } = new List<Item>();

    [BindProperty(SupportsGet = true)]
    public string SearchQuery { get; set; } = string.Empty;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        if (!string.IsNullOrWhiteSpace(SearchQuery))
        {
            var googleSearch = new GoogleSearchService();

            // Get 100 results, 10 at a time, which is the max google allows.
            for (var i = 1; i < 91; i += 10)
            {
                var googleResults = googleSearch.Search(SearchQuery, i, "m6"); // Get next page of results no older than 6 months
                if (googleResults.Items == null) { break; }
                foreach (var item in googleResults.Items)
                {
                    SearchResults.Add(item);
                }
            }
        }
    }
}

