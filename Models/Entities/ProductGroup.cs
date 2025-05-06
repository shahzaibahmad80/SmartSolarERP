using SmartSolarERP.Models.Contracts;

namespace SmartSolarERP.Models.Entities
{
    public class ProductGroup : _Base
    {
        public ProductGroup() { }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
