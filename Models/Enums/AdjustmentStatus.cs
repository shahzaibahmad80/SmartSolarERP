﻿using System.ComponentModel;

namespace SmartSolarERP.Models.Enums
{
    public enum AdjustmentStatus
    {
        [Description("Draft")]
        Draft = 0,
        [Description("Cancelled")]
        Cancelled = 1,
        [Description("Confirmed")]
        Confirmed = 2,
        [Description("Archived")]
        Archived = 3
    }
}
