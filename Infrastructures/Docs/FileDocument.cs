﻿#nullable disable

namespace SmartSolarERP.Infrastructures.Docs
{
    public class FileDocument
    {
        public Guid Id { get; set; }
        public string OriginalFileName { get; set; }
        public byte[] DocumentData { get; set; }
    }
}
