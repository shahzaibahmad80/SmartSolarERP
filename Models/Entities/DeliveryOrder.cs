﻿using SmartSolarERP.Models.Contracts;
using SmartSolarERP.Models.Enums;

namespace SmartSolarERP.Models.Entities
{
    public class DeliveryOrder : _Base
    {
        public DeliveryOrder() { }
        public string? Number { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DeliveryOrderStatus? Status { get; set; }
        public string? Description { get; set; }
        public required int SalesOrderId { get; set; }
        public SalesOrder? SalesOrder { get; set; }
    }
}
