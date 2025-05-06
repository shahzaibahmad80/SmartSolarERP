using SmartSolarERP.Models.Contracts;

namespace SmartSolarERP.Models.Entities
{
    public class UnitMeasure : _Base
    {
        public UnitMeasure() { }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
