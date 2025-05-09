﻿namespace SmartSolarERP.DTOs
{
    public class DeliveryOrderItemChildDto
    {
        public int? Id { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime? CreatedAtUtc { get; set; }
        public int? WarehouseId { get; set; }
        public int? ProductId { get; set; }
        public double? Movement { get; set; }
    }
}
