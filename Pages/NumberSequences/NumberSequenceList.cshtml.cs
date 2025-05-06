using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.NumberSequences
{
    [Authorize]
    public class NumberSequenceListModel : PageModel
    {
        public NumberSequenceListModel() { }

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();
        }

    }
}
