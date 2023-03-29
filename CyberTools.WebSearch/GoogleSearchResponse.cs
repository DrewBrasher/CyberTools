using System;
using Newtonsoft.Json;

namespace CyberTools.WebSearch;
// Generated with https://json2csharp.com/
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public class GoogleSearchResponse
{
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("url")]
    public Url Url { get; set; }

    [JsonProperty("queries")]
    public Queries Queries { get; set; }

    [JsonProperty("context")]
    public Context Context { get; set; }

    [JsonProperty("searchInformation")]
    public SearchInformation SearchInformation { get; set; }

    [JsonProperty("spelling")]
    public Spelling Spelling { get; set; }

    [JsonProperty("items")]
    public List<Item> Items { get; set; }
}

public class Context
{
    [JsonProperty("title")]
    public string Title { get; set; }
}

public class CseImage
{
    [JsonProperty("src")]
    public string Src { get; set; }
}

public class CseThumbnail
{
    [JsonProperty("src")]
    public string Src { get; set; }

    [JsonProperty("width")]
    public string Width { get; set; }

    [JsonProperty("height")]
    public string Height { get; set; }
}

public class Item
{
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("htmlTitle")]
    public string HtmlTitle { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("displayLink")]
    public string DisplayLink { get; set; }

    [JsonProperty("snippet")]
    public string Snippet { get; set; }

    [JsonProperty("htmlSnippet")]
    public string HtmlSnippet { get; set; }

    [JsonProperty("cacheId")]
    public string CacheId { get; set; }

    [JsonProperty("formattedUrl")]
    public string FormattedUrl { get; set; }

    [JsonProperty("htmlFormattedUrl")]
    public string HtmlFormattedUrl { get; set; }

    [JsonProperty("pagemap")]
    public Pagemap Pagemap { get; set; }
}

public class Listitem
{
    [JsonProperty("item")]
    public string Item { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }
}

public class Medicalwebpage
{
    [JsonProperty("audience")]
    public string Audience { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

public class Metatag
{
    [JsonProperty("og:image")]
    public string OgImage { get; set; }

    [JsonProperty("og:type")]
    public string OgType { get; set; }

    [JsonProperty("og:image:alt")]
    public string OgImageAlt { get; set; }

    [JsonProperty("twitter:card")]
    public string TwitterCard { get; set; }

    [JsonProperty("twitter:title")]
    public string TwitterTitle { get; set; }

    [JsonProperty("og:site_name")]
    public string OgSiteName { get; set; }

    [JsonProperty("handheldfriendly")]
    public string Handheldfriendly { get; set; }

    [JsonProperty("msvalidate.01")]
    public string Msvalidate01 { get; set; }

    [JsonProperty("twitter:url")]
    public string TwitterUrl { get; set; }

    [JsonProperty("og:title")]
    public string OgTitle { get; set; }

    [JsonProperty("google")]
    public string Google { get; set; }

    [JsonProperty("og:description")]
    public string OgDescription { get; set; }

    [JsonProperty("article:author")]
    public string ArticleAuthor { get; set; }

    [JsonProperty("article:publisher")]
    public string ArticlePublisher { get; set; }

    [JsonProperty("twitter:image")]
    public string TwitterImage { get; set; }

    [JsonProperty("twitter:image:alt")]
    public string TwitterImageAlt { get; set; }

    [JsonProperty("twitter:site")]
    public string TwitterSite { get; set; }

    [JsonProperty("viewport")]
    public string Viewport { get; set; }

    [JsonProperty("twitter:description")]
    public string TwitterDescription { get; set; }

    [JsonProperty("mobileoptimized")]
    public string Mobileoptimized { get; set; }

    [JsonProperty("og:url")]
    public string OgUrl { get; set; }

    [JsonProperty("dc.publisher")]
    public string DcPublisher { get; set; }

    [JsonProperty("citation_publication_date")]
    public string CitationPublicationDate { get; set; }

    [JsonProperty("citation_title")]
    public string CitationTitle { get; set; }

    [JsonProperty("citation_reference")]
    public string CitationReference { get; set; }

    [JsonProperty("citation_journal_title")]
    public string CitationJournalTitle { get; set; }

    [JsonProperty("ncbi_pdid")]
    public string NcbiPdid { get; set; }

    [JsonProperty("ncbi_pcid")]
    public string NcbiPcid { get; set; }

    [JsonProperty("ncbi_phid")]
    public string NcbiPhid { get; set; }

    [JsonProperty("ncbi_db")]
    public string NcbiDb { get; set; }

    [JsonProperty("dc.type")]
    public string DcType { get; set; }

    [JsonProperty("citation_fulltext_html_url")]
    public string CitationFulltextHtmlUrl { get; set; }

    [JsonProperty("ncbi_app_version")]
    public string NcbiAppVersion { get; set; }

    [JsonProperty("ncbi_type")]
    public string NcbiType { get; set; }

    [JsonProperty("citation_pmid")]
    public string CitationPmid { get; set; }

    [JsonProperty("ncbi_app")]
    public string NcbiApp { get; set; }

    [JsonProperty("citation_author")]
    public string CitationAuthor { get; set; }

    [JsonProperty("citation_abstract_html_url")]
    public string CitationAbstractHtmlUrl { get; set; }

    [JsonProperty("dc.date")]
    public string DcDate { get; set; }

    [JsonProperty("citation_issue")]
    public string CitationIssue { get; set; }

    [JsonProperty("dc.contributor")]
    public string DcContributor { get; set; }

    [JsonProperty("citation_firstpage")]
    public string CitationFirstpage { get; set; }

    [JsonProperty("ncbi_op")]
    public string NcbiOp { get; set; }

    [JsonProperty("dc.title")]
    public string DcTitle { get; set; }

    [JsonProperty("ncbi_domain")]
    public string NcbiDomain { get; set; }

    [JsonProperty("citation_volume")]
    public string CitationVolume { get; set; }

    [JsonProperty("dc.language")]
    public string DcLanguage { get; set; }

    [JsonProperty("article:published_time")]
    public string ArticlePublishedTime { get; set; }

    [JsonProperty("twitter:creator")]
    public string TwitterCreator { get; set; }

    [JsonProperty("og:image:secure_url")]
    public string OgImageSecureUrl { get; set; }

    [JsonProperty("article:modified_time")]
    public object ArticleModifiedTime { get; set; }

    [JsonProperty("rights")]
    public string Rights { get; set; }

    [JsonProperty("og:see_also")]
    public string OgSeeAlso { get; set; }

    [JsonProperty("twitter:site:id")]
    public string TwitterSiteId { get; set; }

    [JsonProperty("og:image:url")]
    public string OgImageUrl { get; set; }

    [JsonProperty("abstract")]
    public string Abstract { get; set; }

    [JsonProperty("og:updated_time")]
    public string OgUpdatedTime { get; set; }

    [JsonProperty("article:tag")]
    public string ArticleTag { get; set; }

    [JsonProperty("twitter:creator:id")]
    public string TwitterCreatorId { get; set; }

    [JsonProperty("og:locale")]
    public string OgLocale { get; set; }

    [JsonProperty("template")]
    public string Template { get; set; }

    [JsonProperty("format-detection")]
    public string FormatDetection { get; set; }

    [JsonProperty("ac-dictionary")]
    public string AcDictionary { get; set; }

    [JsonProperty("dc.identifier.url")]
    public string DcIdentifierUrl { get; set; }

    [JsonProperty("dc.title.alternate")]
    public string DcTitleAlternate { get; set; }

    [JsonProperty("dc.subject.mesh")]
    public string DcSubjectMesh { get; set; }

    [JsonProperty("dc.relation.ispartof")]
    public string DcRelationIspartof { get; set; }

    [JsonProperty("dc.date.created")]
    public string DcDateCreated { get; set; }

    [JsonProperty("fb:app_id")]
    public string FbAppId { get; set; }

    [JsonProperty("dc.date.modified")]
    public string DcDateModified { get; set; }

    [JsonProperty("fb:pages")]
    public string FbPages { get; set; }

    [JsonProperty("expires")]
    public string Expires { get; set; }

    [JsonProperty("msapplication-tap-highlight")]
    public string MsapplicationTapHighlight { get; set; }

    [JsonProperty("tec-api-origin")]
    public string TecApiOrigin { get; set; }

    [JsonProperty("msapplication-tileimage")]
    public string MsapplicationTileimage { get; set; }

    [JsonProperty("tec-api-version")]
    public string TecApiVersion { get; set; }

    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("policy-code")]
    public string PolicyCode { get; set; }

    [JsonProperty("dc.service")]
    public string DcService { get; set; }

    [JsonProperty("dc.iso3166")]
    public string DcIso3166 { get; set; }

    [JsonProperty("last-modified")]
    public string LastModified { get; set; }

    [JsonProperty("sdg-tag")]
    public string SdgTag { get; set; }
}

public class NextPage
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("totalResults")]
    public string TotalResults { get; set; }

    [JsonProperty("searchTerms")]
    public string SearchTerms { get; set; }

    [JsonProperty("count")]
    public int Count { get; set; }

    [JsonProperty("startIndex")]
    public int StartIndex { get; set; }

    [JsonProperty("inputEncoding")]
    public string InputEncoding { get; set; }

    [JsonProperty("outputEncoding")]
    public string OutputEncoding { get; set; }

    [JsonProperty("safe")]
    public string Safe { get; set; }

    [JsonProperty("cx")]
    public string Cx { get; set; }
}

public class Pagemap
{
    [JsonProperty("cse_thumbnail")]
    public List<CseThumbnail> CseThumbnail { get; set; }

    [JsonProperty("metatags")]
    public List<Metatag> Metatags { get; set; }

    [JsonProperty("cse_image")]
    public List<CseImage> CseImage { get; set; }

    [JsonProperty("listitem")]
    public List<Listitem> Listitem { get; set; }

    [JsonProperty("medicalwebpage")]
    public List<Medicalwebpage> Medicalwebpage { get; set; }
}

public class Queries
{
    [JsonProperty("request")]
    public List<Request> Request { get; set; }

    [JsonProperty("nextPage")]
    public List<NextPage> NextPage { get; set; }
}

public class Request
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("totalResults")]
    public string TotalResults { get; set; }

    [JsonProperty("searchTerms")]
    public string SearchTerms { get; set; }

    [JsonProperty("count")]
    public int Count { get; set; }

    [JsonProperty("startIndex")]
    public int StartIndex { get; set; }

    [JsonProperty("inputEncoding")]
    public string InputEncoding { get; set; }

    [JsonProperty("outputEncoding")]
    public string OutputEncoding { get; set; }

    [JsonProperty("safe")]
    public string Safe { get; set; }

    [JsonProperty("cx")]
    public string Cx { get; set; }
}

public class SearchInformation
{
    [JsonProperty("searchTime")]
    public double SearchTime { get; set; }

    [JsonProperty("formattedSearchTime")]
    public string FormattedSearchTime { get; set; }

    [JsonProperty("totalResults")]
    public string TotalResults { get; set; }

    [JsonProperty("formattedTotalResults")]
    public string FormattedTotalResults { get; set; }
}

public class Spelling
{
    [JsonProperty("correctedQuery")]
    public string CorrectedQuery { get; set; }

    [JsonProperty("htmlCorrectedQuery")]
    public string HtmlCorrectedQuery { get; set; }
}

public class Url
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("template")]
    public string Template { get; set; }
}

