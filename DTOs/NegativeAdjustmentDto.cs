﻿using SmartSolarERP.Models.Enums;

namespace SmartSolarERP.DTOs
{
    public class NegativeAdjustmentDto
    {
        public int? Id { get; set; }
        public string? Number { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public AdjustmentStatus? Status { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime? CreatedAtUtc { get; set; }
    }
}
