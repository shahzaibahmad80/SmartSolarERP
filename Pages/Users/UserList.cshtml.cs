using SmartSolarERP.Infrastructures.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.Users
{
    [Authorize]
    public class UserListModel : PageModel
    {
        public UserListModel() { }

        public void OnGet()
        {
            this.SetupViewDataTitleFromUrl();
        }





    }
}
