using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace taghelperexample.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [DisplayName("Ten nguoi dung")]
    public string UserName {get;set;} = "XuanThuLab";

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
