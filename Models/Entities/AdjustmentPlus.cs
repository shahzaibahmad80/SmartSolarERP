using SmartSolarERP.Models.Contracts;
using SmartSolarERP.Models.Enums;

namespace SmartSolarERP.Models.Entities
{
    public class AdjustmentPlus : _Base
    {
        public AdjustmentPlus() { }
        public string? Number { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public AdjustmentStatus? Status { get; set; }
        public string? Description { get; set; }
    }
}
