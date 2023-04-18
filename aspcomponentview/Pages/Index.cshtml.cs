using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XTLAB;

namespace aspcomponentview.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnPost(){
        var message = new MessagePage.Message();
        var username = this.Request.Form["username"];
        message.title = "Thong bao";
        message.htmlcontent = $"Cam on {username}, ban da gui thong tin";
        message.secondwait = 7;
        message.urlredirect = Url.Page("Privacy");
        return ViewComponent("MessagePage", message);
    }
    // public IActionResult OnGet()
    // {
    //     //PageModel: Partial, ViewComponent
    //     //Controller: PartialView, ViewComponent
    //     return ViewComponent("ProductBox", false);
    // }
}
