using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.LogAnalytics
{
    [Authorize]
    public class LogAnalyticListModel : PageModel
    {
        public LogAnalyticListModel() { }

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();
        }

    }
}
