using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.Companies
{
    [Authorize]
    public class CompanyListModel : PageModel
    {
        public CompanyListModel() { }

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();

        }



    }
}
