using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIS341_Lab03.Pages;

// <snippet_Class>
[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public class StatusCodeModel : PageModel
{
    private readonly ILogger _logger;
    public int OriginalStatusCode { get; set; }

    public string? OriginalPathAndQuery { get; set; }

    public StatusCodeModel(ILogger<StatusCodeModel> logger)
    {
        _logger = logger;
    }
    public void OnGet(int statusCode)
    {

        OriginalStatusCode = statusCode;

        var statusCodeReExecuteFeature =
            HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

        if (statusCodeReExecuteFeature is not null)
        {
            OriginalPathAndQuery = string.Join(
                statusCodeReExecuteFeature.OriginalPathBase,
                statusCodeReExecuteFeature.OriginalPath,
                statusCodeReExecuteFeature.OriginalQueryString);
        }
        /*
         * Log relevant information about the error using the 
         * conceptually appropriate Log* method in the Logger interface. 
         * Include at least the client's user agent information, the 
         * requested URL, and the HTTP status code. – 1 point
        */
        _logger.LogError($"StatusCode page hit at " +
            $"{DateTime.UtcNow.ToLongTimeString()}" +
            $" with code:{OriginalStatusCode}");
        _logger.LogError($"{OriginalPathAndQuery}");
        //_logger.LogError($"{HttpContext.Features.Get<>}");
    }
}