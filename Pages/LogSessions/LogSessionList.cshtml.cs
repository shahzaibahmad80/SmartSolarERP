using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.LogSessions
{
    [Authorize]
    public class LogSessionListModel : PageModel
    {
        public LogSessionListModel() { }

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();
        }

    }
}
