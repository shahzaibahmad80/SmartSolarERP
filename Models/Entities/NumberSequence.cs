﻿using SmartSolarERP.Models.Contracts;

namespace SmartSolarERP.Models.Entities
{
    public class NumberSequence : _Base
    {
        public NumberSequence() { }
        public required string EntityName { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public int LastUsedCount { get; set; }
    }
}
