using Microsoft.AspNetCore.Mvc.Rendering;

namespace SmartSolarERP.Infrastructures.Countries
{
    public interface ICountryService
    {
        ICollection<SelectListItem> GetCountries();
    }
}
