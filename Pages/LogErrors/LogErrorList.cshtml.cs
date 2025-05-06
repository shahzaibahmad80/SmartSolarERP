using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.LogErrors
{
    [Authorize]
    public class LogErrorListModel : PageModel
    {
        public LogErrorListModel() { }

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();
        }

    }
}
