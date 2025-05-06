using Microsoft.AspNetCore.Mvc.Rendering;

namespace SmartSolarERP.Infrastructures.Currencies
{
    public interface ICurrencyService
    {
        ICollection<SelectListItem> GetCurrencies();
    }
}
