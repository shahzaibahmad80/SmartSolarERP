using SmartSolarERP.Applications.UnitMeasures;
using SmartSolarERP.Models.Entities;

namespace SmartSolarERP.Data.Demo
{
    public static class DemoUnitMeasure
    {
        public static async Task GenerateAsync(IServiceProvider services)
        {
            var service = services.GetRequiredService<UnitMeasureService>();

            await service.AddAsync(new UnitMeasure { Name = "m" });
            await service.AddAsync(new UnitMeasure { Name = "kg" });
            await service.AddAsync(new UnitMeasure { Name = "hour" });
            await service.AddAsync(new UnitMeasure { Name = "unit" });
        }
    }
}
