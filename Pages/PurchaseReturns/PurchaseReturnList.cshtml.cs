using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.PurchaseReturns
{
    [Authorize]
    public class PurchaseReturnListModel : PageModel
    {
        public PurchaseReturnListModel() { }

        [TempData]
        public string StatusMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();
            this.SetupStatusMessage();
            StatusMessage = this.ReadStatusMessage();
        }





    }
}
