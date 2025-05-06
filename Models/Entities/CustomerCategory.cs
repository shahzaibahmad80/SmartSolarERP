using SmartSolarERP.Models.Contracts;

namespace SmartSolarERP.Models.Entities
{
    public class CustomerCategory : _Base
    {
        public CustomerCategory() { }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
