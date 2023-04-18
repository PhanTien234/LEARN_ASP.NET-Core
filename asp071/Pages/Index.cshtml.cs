using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp071.Pages;

public class IndexModel : PageModel
{
    public string Abc {set; get;}
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        this.Abc = "Day la noi dung trong ABC";
    }
}
