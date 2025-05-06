using Microsoft.AspNetCore.Mvc.Rendering;

namespace SmartSolarERP.Infrastructures.TimeZones
{
    public interface ITimeZoneService
    {
        ICollection<SelectListItem> GetAllTimeZones();
    }
}
